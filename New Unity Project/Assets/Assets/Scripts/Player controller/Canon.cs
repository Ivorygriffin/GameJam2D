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
        Vector2 Canonpos = transform.position;

        direction = MousePos - Canonpos;

   
        FaceMouse();
    }

    void FaceMouse()
    {
        transform.right = direction;
    }
}
