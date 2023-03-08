using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float moveSpeed  = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    

    // // Update is called once per frame
    // void Update()
    // {
    //     //input
    //     movement.x = Input.GetAxisRaw("Horizontal");
    //     movement.y = Input.GetAxisRaw("Verical");
    // }

    // void FixedUpdate(){
    //     //movement
    //     rb.MovePostition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    // }
}