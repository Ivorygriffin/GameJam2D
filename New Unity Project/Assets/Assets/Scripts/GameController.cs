using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public enum CampType 
{
    socialising,
    relaxing

}
public enum ItemType 
{
    apple,
    water,
    tea,
    sleep,
    alcohol,
    candy,
    tv,
    fastFood


}


public class GameController : MonoBehaviour
{
    

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
    public GameObject camp1,camp2;
    public GameObject slider1, slider2, slider3;
    public GameObject refreshScreen, antiRefresh, screen1, screen2,screen3;

    [Header("Sliders")]
    public Slider s1, s2, s3;

    [Header("floats")]
    public float s1Max;
    public float s2Max;
    public float s3Max;
    public float currentScore;

    [Header("bools")]
    private bool _slider1, _slider2, _slider3;

    
    
    void Start()
    {
        _slider1 = true;
        _slider2 = false;
        _slider3 = false;
    }


    void Update()
    {
        ScoreTextUpdate();
        //MountainClimbing();
        PointCheck();
        
    }

    public void ScoreTextUpdate()
    {
        ScoreText.text = currentScore.ToString();
    }

  

    //public void MountainClimbing()
    //{
    //    // UI person climbs more depending on score collected
    //    //slider moves stick figure up 
    //    if (_slider1 == true && currentScore != s1Max)
    //    {
    //        s1.value = currentScore;
    //    }
    //    if (currentScore == s1Max && _slider1 == true)
    //    {
    //        slider1.SetActive(false);
    //        _slider1 = false;
    //        slider2.SetActive(true);
    //        _slider2 = true;
    //    }
    //    if(_slider2 == true && currentScore != s2Max)
    //    {
    //        s2.value = currentScore;
    //    }
    //    if (currentScore == s2Max && _slider2 == true)
    //    {
    //        slider2.SetActive(false);
    //        _slider2 = false;
    //        slider3.SetActive(true);
    //        _slider3 = true;
    //    }
    //    if(_slider3 == true && currentScore != s3Max)
    //    {
    //        s3.value = currentScore;
    //    }

    //}
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
            currentBall -= 1;
        }


    }
   

    public void Socialising()
    {
        //more good pegs on screen
    }

    public void Relaxing()
    {
        // super good appears
    }

    public void LevelComplete()
    {
        //third camp reached triggers end of level 
        if(currentScore == finalCampScore)
        {
            Debug.Log("levelComplete");
        }
    }

    public void GameOver()
    {
        
    }

    public void ItemHit()
    {
        //item collision determines number of points added
       

    }

    public void PointCheck()
    {
        //checks if number of points reaches a camp
        if(currentScore == camp1Score)
        {
            camp1.SetActive(true);
             // go into different script attached to camp in scene and check type
        }
        if(currentScore == camp2Score)
        {
            camp1.SetActive(false);
            camp2.SetActive(true);
            // go into different script attached to camp in scene and check type
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






























}
