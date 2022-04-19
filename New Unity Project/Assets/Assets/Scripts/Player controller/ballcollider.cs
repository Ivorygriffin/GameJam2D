using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollider : MonoBehaviour
{

    public GameController GC;
    public AudioSource good;
    public AudioSource bad;
    

  

    private void Start()
    {
       GC = FindObjectOfType<GameController>();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "apple")
        {
            GC.GetComponent<GameController>().apple();
            good.Play();
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.tag == "sleep")
        {
            GC.GetComponent<GameController>().sleep();
            good.Play();
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "alcohol")
        {
            GC.GetComponent<GameController>().alcohol();
            bad.Play();
            collision.gameObject.SetActive(false);
        }  
        if(collision.gameObject.tag == "candy")
        {
            GC.GetComponent<GameController>().candy();
            bad.Play();
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "tea")
        {
            GC.GetComponent<GameController>().tea();
            good.Play();
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "tv")
        {
            GC.GetComponent<GameController>().tv();
            bad.Play();
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.tag == "water")
        {
            GC.GetComponent<GameController>().SuperGood();
            good.Play();
            collision.gameObject.SetActive(false);
        } 
        if(collision.gameObject.tag == "fries")
        {
            GC.GetComponent<GameController>().SuperBad();
            bad.Play();
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }

    }
   
}
