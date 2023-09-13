using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private float speed = 8f;
    private float horizontal;
    private float jumpingpower = 16f;
    private bool isFaceingRight = true;

/*    private Animator anim;
    private string Walk_Animation = "Walk";*/

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AnimatePlayer();

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        Flip();
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFaceingRight && horizontal < 0f || !isFaceingRight && horizontal > 0f)
        {
            isFaceingRight = !isFaceingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }

    }

   /* void AnimatePlayer()
    {
        if (rb.velocity.x > 0)
        {
            anim.SetBool(Walk_Animation, true);
            isFaceingRight = false;
        }
        else if (rb.velocity.x < 0)
        {
            anim.SetBool(Walk_Animation, true);
            isFaceingRight = true;
        }
        else
        {
            anim.SetBool(Walk_Animation, false);
        }
    }*/


}
