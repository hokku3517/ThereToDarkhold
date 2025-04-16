using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{

    private float vertical;

    private float speed = 8f;

    private bool isLadder;

    private bool isClimbing;
    [SerializeField] private Rigidbody2D rb;

    public PlayerMovement playerMovementScript;
    

    private bool _isDashing;
    
    
    // Update is called once per frame
    void Update()
    {
        
        vertical = Input.GetAxis("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        
       
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        
        _isDashing = playerMovementScript.isDashing;
        if (_isDashing)
        {
            rb.gravityScale = 0f;
        }
        else
        {
            rb.gravityScale = 4f;
        }

           

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
            rb.gravityScale = 4f;
        }
    }
}
