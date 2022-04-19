using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        trackMovement();
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }







}
