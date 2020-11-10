using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text liveText;
    [Header("Pause/UI Element")]
    public Text pauseText;
    public Image backgroundImage;
    public Button continueButton;
    public Button exitButton;
    public Ball ball;
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
                break;
            }
        }
    }
    void Start()
    {
      

        ball = FindObjectOfType<Ball>();

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
        Cursor.visible = false;
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    public void PressExitButton()
    {
        Application.Quit();
    }
    
}
