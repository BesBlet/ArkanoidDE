using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Cursor = UnityEngine.Cursor;
using Image = UnityEngine.UI.Image;

public class GameManager : MonoBehaviour
{
    [Header("Score/UI Element")]
    public Text scoreText;
    public Text liveText;
    public Image lifeImage1;
    public Image lifeImage2;
    public Image lifeImage3;

    [Header("Pause/UI Element")]
    public Text pauseText;
    public Image backgroundImage;
    public Button continueButton;
    public Button exitButton;
  
    
    
    
    [Header("GameOver/UI Element")]
    public Text gameOverText;
    public Button restartButton;

    public bool pauseActive;
    public int score;
    public int live = 3;
    private void Awake()
    {
        GameManager[] gameManagers = FindObjectsOfType<GameManager>();
        for(int i= 0; i < gameManagers.Length; i++)
        {
            if (gameManagers[i].gameObject != gameObject)
            {
                Destroy(gameObject);
                gameObject.SetActive(false);
                break;
            }
        }
    }
    void Start()
    {
        scoreText.text = "0000";

        DontDestroyOnLoad(gameObject);
    }

   
    void Update()
    {
        scoreText.text = score.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pauseActive)
            {
               PressContinueButton();
            }
            else
            {
                Time.timeScale = 0f;
                pauseActive = true;
                SetPause();
            }
            
        }
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
        
    }

    void SetPause()
    {
        backgroundImage.gameObject.SetActive(pauseActive);
        pauseText.gameObject.SetActive(pauseActive);
        continueButton.gameObject.SetActive(pauseActive);
        exitButton.gameObject.SetActive(pauseActive);
        Cursor.visible = pauseActive;
    }

    public void LiveViewer()
    {
       
        liveText.text = live.ToString();
        
    }
    public void PressContinueButton ()
    {
        Time.timeScale = 1f;
        pauseActive = false;
        SetPause(); 
    }

    public void PressRestartButton()
    {
        gameOverText.gameObject.SetActive(false);
        backgroundImage.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        
        lifeImage3.gameObject.SetActive(true);
        lifeImage2.gameObject.SetActive(true);
        lifeImage1.gameObject.SetActive(true);
        
        Cursor.visible = false;
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    public void PressExitButton()
    {
        Application.Quit();
    }

    public void LifeImage()
    {
       
        if (live == 2)
        {
            lifeImage3.gameObject.SetActive(false);
        }
        else if (live == 1)

        {
            lifeImage2.gameObject.SetActive(false);
        }
        else if (live == 0)
        {
            lifeImage1.gameObject.SetActive(false);
        }
    }
    
}
