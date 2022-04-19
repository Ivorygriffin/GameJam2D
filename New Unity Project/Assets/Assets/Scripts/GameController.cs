using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameController : MonoBehaviour
{
    public string MainMenu;
    public string Level1;
    public string win;
    public string lose;

    [Header("Text")]
    public TMP_Text ScoreText;
    public TMP_Text BallsRemaining;
    public TMP_Text PointsUntilNextCamp;
   

    [Header("Ints")]
    
    public int camp1Score;
    public int camp2Score;
    public int finalCampScore;
    public int alcoholVal, appleVal, teaVal, sleepVal, candyVal, tvVal;
    public int currentBall, maxBalls;


    [Header("GameObjects")]
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject refreshScreen, antiRefresh, screen1, screen2,screen3, gameoverScreen, winScreen, pauseMenu;
    public GameObject Canonn;

    [Header("Sliders")]
    public Slider s1, s2, s3;

    [Header("floats")]
    public float s1Max;
    public float s2Max;
    public float s3Max;
    public int currentScore;

    [Header("bools")]
    private bool _slider1, _slider2, _slider3;
    private bool hasrun1, hasrun2;

    
    
    void Start()
    {
        _slider1 = true;
        _slider2 = false;
        _slider3 = false;

        Cursor.lockState = CursorLockMode.Confined;
    }


    void Update()
    {
        ScoreTextUpdate();
        MountainClimbing();
        PointCheck();
        BallText();
        //PauseMenu();
        LevelComplete();
        
        
    }

    public void ScoreTextUpdate()
    {
        ScoreText.text = currentScore.ToString();
        
    }

  

    public void MountainClimbing()
    {
         
        if (_slider1 == true && currentScore < s1Max)
        {
            s1.value = currentScore;
        }
        if (currentScore >= s1Max && _slider1 == true)
        {
            slider1.SetActive(false);
            _slider1 = false;
            slider2.SetActive(true);
            _slider2 = true;
        }
        if (_slider2 == true && currentScore < s2Max)
        {
            s2.value = currentScore;
        }
        if (currentScore >= s2Max && _slider2 == true)
        {
            slider2.SetActive(false);
            _slider2 = false;
            slider3.SetActive(true);
            _slider3 = true;
        }
        if (_slider3 == true && currentScore < s3Max)
        {
            s3.value = currentScore;
        }

    }
    public void BallText()
    {
        BallsRemaining.text = currentBall.ToString();
    }

    public void UpdateBalls()
    {
        if (currentBall == maxBalls)
        {
            GameOver();
            Debug.Log("lose");
        }
        else
        {
            currentBall += 1;
        }


    }
   

    public void Socialising()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);

    }

    public void Relaxing()
    {
        screen2.SetActive(false);
        screen3.SetActive(true);
    }

    public void LevelComplete()
    {
        //third camp reached triggers end of level 
        if(currentScore >= finalCampScore)
        {

            SceneManager.LoadScene(win);

            Debug.Log("levelComplete");
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(lose);
        Debug.Log("lose");
    }


    public void PointCheck()
    {
        //checks if number of points reaches a camp
        if(currentScore >= camp1Score && hasrun1 == false)
        {
            Socialising();
            currentBall = 0;
            hasrun1 = true;
            
        }
        if(currentScore >= camp2Score && hasrun2 == false)
        {
            Relaxing();
            currentBall = 0;
            hasrun2 = true;
        }




    }
    public void SuperBad()
    {
        screen1.SetActive(false);
        screen2.SetActive(false);
        screen3.SetActive(false);
        refreshScreen.SetActive(false);
        antiRefresh.SetActive(false);
        antiRefresh.SetActive(true);
        
    }

    public void SuperGood()
    {
        screen1.SetActive(false);
        screen2.SetActive(false);
        screen3.SetActive(false);
        refreshScreen.SetActive(false);
        antiRefresh.SetActive(false);
        refreshScreen.SetActive(true);
    }

 

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }  
    public void LoadLevel1()
    {
        SceneManager.LoadScene(Level1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseMenu()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

  


    public void apple()
    {
        currentScore += appleVal;

    } 
    public void tv()
    {
        currentScore += tvVal;

    } 
    public void alcohol()
    {
        currentScore += alcoholVal;

    } 
    public void sleep()
    {
        currentScore += sleepVal;

    }
    public void tea()
    {
        currentScore += teaVal;

    }
    public void candy()
    {
        currentScore += candyVal;

    }

















}
