using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camp : MonoBehaviour
{
    public CampType campType;
    public GameController GC;
    void Start()
    {
        CheckCampType();
    }

 
    void Update()
    {
        
    }
    public void CheckCampType()
    {
        //on awake 
        switch (campType)
        {
            case CampType.socialising:
                GC.GetComponent<GameController>().Socialising();
                Debug.Log("socialising");
                break;

            case CampType.relaxing:
                GC.GetComponent<GameController>().Relaxing();
                Debug.Log("relaxing");
                break;

            default:
                Debug.Log("campType not set");
                break;

                
        }


    }
}
