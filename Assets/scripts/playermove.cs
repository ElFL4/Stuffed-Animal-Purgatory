using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

// I watched the Pandemonium "Unity 2D Platformer for Complete Beginners" playlist for this part below.
public class playermove : MonoBehaviour
{
    [SerializeField] public float speed;
    private Rigidbody2D bunnypurple;
    public int force;
    private bool grounded;

    private void Awake()
    {
        bunnypurple = GetComponent<Rigidbody2D>();
    } 

    private void Jump()
    {
        bunnypurple.linearVelocity = new Vector2(bunnypurple.linearVelocityX, speed * 2);
        grounded = false;
    }

    private void Update()
    {
        // key press? left or right for now...
        bunnypurple.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, bunnypurple.linearVelocity.y);
    
        // it feels similar to that one hw with all the windows on press stuff I think
        if(Input.GetKeyDown(KeyCode.Space) && grounded) 
        {
            Jump();
        }

        if(Input.GetKeyUp(KeyCode.Space) && bunnypurple.linearVelocityY >0)
        {
            // jumping = false
            bunnypurple.linearVelocity = new Vector2(bunnypurple.linearVelocityX, bunnypurple.linearVelocityY / 2);
        }

        
        // // to restart/escape your playthough
        // if(Input.GetKey(KeyCode.Escape))
        // {
        //     // ...
        // }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}

