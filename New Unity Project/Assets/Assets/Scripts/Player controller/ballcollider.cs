using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollider : MonoBehaviour
{

    public GameController GC;
    Item item;

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
        if (gameObject.tag == "apple")
        {
            CS += APV;
            Destroy(collision.gameObject);
        }
        if(gameObject.tag == "sleep")
        {
            CS += SV;
            Destroy(collision.gameObject);
        } 
        if(gameObject.tag == "alcohol")
        {
            CS += AV;
            Destroy(collision.gameObject);
        }  
        if(gameObject.tag == "candy")
        {
            CS += CV;
            Destroy(collision.gameObject);
        } 
        if(gameObject.tag == "tea")
        {
            CS += TV;
            Destroy(collision.gameObject);
        } 
        if(gameObject.tag == "tv")
        {
            CS += TVV;
            Destroy(collision.gameObject);
        }


    }
   
}
