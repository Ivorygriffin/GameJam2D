using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public Vector2 direction;


    void Start()
    {
        
    }

    
    void Update()
    {
        
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 canonpos = transform.position;
        //Debug.Log(canonpos);
        //Debug.Log(MousePos);

        direction = transform.right;
   
        FaceMouse();
    }

    void FaceMouse()
    {
        transform.right = direction;
    }
}
