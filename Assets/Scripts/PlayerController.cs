using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4.0f;
    private float move;

    public LayerMask WhatIsGround;
    public GameObject GroundCheck;
    private bool isGrounded = false;
    private int jumps = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, 0.2f);
    }


    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            jumps -= 1;
        }
        
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(new Vector2(rb.position.x + move * speed * Time.fixedDeltaTime, rb.position.y));
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(GroundCheck.transform.position, 0.2f, WhatIsGround);
        if (isGrounded)
        {
            jumps = 1;
        }
    }
}
