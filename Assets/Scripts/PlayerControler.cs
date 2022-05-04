using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float JumpForce;
    Rigidbody2D rb;
    void Awake()
    {
      rb = GetComponent<Rigidbody2D>();     
    }

    void Update()
    {
      Movement();   
    }

    void Movement()
    {
        if(Input.GetKey(KeyCode.D))
        {
         rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        else if(Input.GetKey(KeyCode.A))
        {
         rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        else rb.velocity = new Vector2(0, rb.velocity.y);

         if(Input.GetKeyDown(KeyCode.Space) && CheckGround.IsGrounded)
        {
         rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
    }
}
