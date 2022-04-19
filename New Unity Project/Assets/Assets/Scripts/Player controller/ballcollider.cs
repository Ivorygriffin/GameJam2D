using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollider : MonoBehaviour
{

    public GameController GC;


    int AV, APV, CV, SV, TV, TVV;
    public float CS;
  

    private void Start()
    {
        CS = GC.GetComponent<GameController>().currentScore;
        AV = GC.GetComponent<GameController>().alcoholVal;
        APV = GC.GetComponent<GameController>().appleVal;
        TVV = GC.GetComponent<GameController>().tvVal;
        TV = GC.GetComponent<GameController>().teaVal;
        CV = GC.GetComponent<GameController>().candyVal;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "apple")
        {
            CS += APV;
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.tag == "sleep")
        {
            CS += SV;
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "alcohol")
        {
            CS += AV;
            collision.gameObject.SetActive(false);
        }  
        if(collision.gameObject.tag == "candy")
        {
            CS += CV;
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "tea")
        {
            CS += TV;
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "tv")
        {
            CS += TVV;
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.tag == "water")
        {
            GC.GetComponent<GameController>().SuperGood();
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "fries")
        {
            GC.GetComponent<GameController>().SuperBad();
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }

    }
   
}
