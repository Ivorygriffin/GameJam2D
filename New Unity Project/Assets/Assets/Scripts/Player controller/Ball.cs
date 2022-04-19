using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float force;
    public GameObject ball;



    
    void Start()
    {
        
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
}
