using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// credit/the place I got help from goes to Restful Coder on Youtube, with their "Unity Pixel Art Game Tutorial - Complete Starting Setup"
// https://www.youtube.com/watch?v=PAA_lCutsfE 

// public class ghostmove : MonoBehaviour
// {
//     // this is going to be a power up from Dolly...
//     if (...) 
//         {
//             public int speed = 10;
//             private Rigidbody2D bunnypurple;
//             private Vector2 velocity;
//             private Vector2 inputMovement; 

//             // Start is called once before the first execution of Update after the MonoBehaviour is created
//             void Start()
//             {
//                 velocity = new Vector2(speed, speed);
//                 bunnypurple = GetComponent<Rigidbody2D>();
//             }

//             // Update is called once per frame
//             void Update()
//             {
//                 inputMovement = new Vector2 (
//                     Input.GetAxis("Horizontal"),
//                     Input.GetAxis("Vertical")
//                 ); // I was using {} instead of ()
//                 // I cannot read D:
//             }

//             void FixedUpdate()
//             {
//                 Vector2 delta = inputMovement * velocity * Time.deltaTime;
//                 Vector2 newPosition = bunnypurple.position + delta;
//                 bunnypurple.MovePosition(newPosition);
//             }

//             // after creating the tileset background, I abandon the previously mentioned tutorial.
//     }
// }
