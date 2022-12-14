using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5;
    bool moveX;
    bool moveY;
    float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Velocity();
        RotatePlayer();
    }
    void Velocity()
    {
        if (moveX && moveY)
        {
            speed = 3.54f;
        }
        else
        {
            speed = 5;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveY = true;
            rb.velocity = new Vector3(rb.velocity.x, speed, rb.velocity.z);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            moveY = true;
            rb.velocity = new Vector3(rb.velocity.x, -speed, rb.velocity.z);
        }

        else
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            moveY = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = true;
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            moveX = true;
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
        }

        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
            moveX = false;
        }
    }

    void RotatePlayer()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;
        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
