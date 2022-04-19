using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public Vector2 direction;
    public Vector3 mousePosition;
    public float force;
    //public GameObject pointPrefab;
    //public GameObject[] points;
    //public int numberOfPoints;

    void Start()
    {
        //points = new GameObject[numberOfPoints];

        //for (int i = 0; i < numberOfPoints; i++)
        //{
        //    points[i] = Instantiate(pointPrefab, transform.position, Quaternion.identity);
        //}
        
    }

    
    void Update()
    {
        
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Canonpos = transform.position;

        direction = MousePos - Canonpos;

   
        FaceMouse();

        //for (int i = 0; i < points.Length; i++)
        //{
        //    points[i].transform.position = PointPosition(i * 0.1f);
        //}

    }

    void FaceMouse()
    {
        transform.up = direction;
    }

    //Vector2 PointPosition(float t)
    //{
    //    Vector2 currentPointPos = (Vector2)transform.position + (direction.normalized * force * t) + 0.5f * Physics2D.gravity * (t * t);
    //    return currentPointPos;
    //}
}
