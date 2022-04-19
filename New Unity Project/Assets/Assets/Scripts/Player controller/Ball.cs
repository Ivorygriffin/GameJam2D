using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float force;
    public GameObject ball;
    public bool hit;


    public ItemType itemType;
    public GameController GC;

    int AV, APV, CV, SV, TV, TVV;
    public float CS;




    void Start()
    {
        CS = GC.GetComponent<GameController>().currentScore;
        AV = GC.GetComponent<GameController>().alcoholVal;
        APV = GC.GetComponent<GameController>().appleVal;
        TVV = GC.GetComponent<GameController>().tvVal;
        TV = GC.GetComponent<GameController>().teaVal;
        CV = GC.GetComponent<GameController>().candyVal;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject BallIns = Instantiate(ball, transform.position, transform.rotation);

        BallIns.GetComponent<Rigidbody2D>().velocity = transform.right * force;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "item")
        {
            ItemHit();
        }
        
        
    }
    public void ItemHit()
    {
        switch (itemType)
        {
            case ItemType.alcohol:
                CS += AV;
                Debug.Log("alcohol");
                break;

            case ItemType.apple:
                CS += APV;
                Debug.Log("apple");
                break;

            case ItemType.candy:
                CS += CV;
                Debug.Log("candy");
                break;

            case ItemType.fastFood:
                GC.GetComponent<GameController>().SuperBad();
                Debug.Log("fast");
                break;

            case ItemType.sleep:
                CS += SV;
                Debug.Log("sleep");
                break;

            case ItemType.tea:
                CS += TV;
                Debug.Log("tea");
                break;

            case ItemType.tv:
                CS += TVV;
                Debug.Log("tv");
                break;

            case ItemType.water:
                GC.GetComponent<GameController>().SuperGood();
                Debug.Log("water");
                break;

            default:
                Debug.Log("not item type assigned");
                break;



        }
    }
}
