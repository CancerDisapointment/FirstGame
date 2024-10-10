using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpMult;
    public Transform GroundCheck;
    private Rigidbody2D rb;
    private bool onGround;
    public LayerMask ground;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        onGround = Physics2D.BoxCast(new Vector2(GroundCheck.position.x, GroundCheck.position.y), new Vector2(0.9f, 0.3f), 0f, Vector2.down, 0.9f, ground);

        Debug.Log(onGround);

        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            Debug.Log(onGround);

            rb.AddForce(new Vector2(0, jumpMult));
        }

        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

       

       


    }
}



