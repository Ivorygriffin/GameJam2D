using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryPrediction : MonoBehaviour
{
    public float force;
    public GameObject ball;


    [Header("Liner Renderer Variables")]
    public LineRenderer line;
    [Range(2,30)]
    public int resolution;


    [Header("formula variables")]
    public Vector2 velocity;
    public float yLimit;
    public float g; // gravity

    [Header("Linecast variables")]
    [Range(2,30)]
    public int lineCastResolution;
    public LayerMask canHit;


    private void Start()
    {
        g = Mathf.Abs(Physics2D.gravity.y);
    }

    private void Update()
    {
        StartCoroutine(RenderArc());
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
      public void Shoot()
    {
        GameObject BallIns = Instantiate(ball, transform.position, transform.rotation);

        BallIns.GetComponent<Rigidbody2D>().AddForce(transform.right * force);
    }


    private IEnumerator RenderArc()
    {
        line.positionCount = resolution + 1;
        line.SetPositions(CalculateLineArray());
        yield return null;
    }

    private Vector3[] CalculateLineArray()
    {

        

        Vector3[] lineArray = new Vector3[resolution + 1];
        var LowestTimeValue = MaxTimeX() / resolution;

        for (int i = 0; i< lineArray.Length; i++)
        {
            var t = LowestTimeValue * i;
            lineArray[i] = CalculateLinePoint(t);
        }
        return lineArray;
    }

    private Vector3 CalculateLinePoint(float t)
    {
        float x = velocity.x * t;
        float y = (velocity.y * t) - (g * Mathf.Pow(t, 2) / 2);
        return new Vector3(x + transform.position.x, y + transform.position.y);
    }

    private Vector2 HitPosition()
    {
        var LowestTimeValue = MaxTimeY() / lineCastResolution;

        for(int i = 0;i< lineCastResolution + 1; i++)
        {
            var t = LowestTimeValue * 1;
            var tt = LowestTimeValue * (i+ 1);

            var hit = Physics2D.Linecast(CalculateLinePoint(t), CalculateLinePoint(tt), canHit);
            if (hit)
                return hit.point;
        }
        return CalculateLinePoint(MaxTimeY());
    }

    private float MaxTimeY()
    {
        var v = velocity.y;
        var vv = v * v;

        var t = (v + Mathf.Sqrt(vv + 2 * g * (transform.position.y - yLimit))) / g;
        return t;
    }

    private float MaxTimeX()
    {
        var x = velocity.x;
        var t = (HitPosition().x - transform.position.x) / x;
        return t;
    }











}





















