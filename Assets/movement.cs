using System;
using UnityEngine;

public class movement : MonoBehaviour
{


    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    Animator animator;
    bool LR;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
        animator.SetFloat("xVelocity", rb.linearVelocity.x);
        animator.SetFloat("yVelocity", rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("facingR", false);
            animator.SetBool("facingL", true);
            if (rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0)
            {
                animator.SetBool("facingL", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("facingL", false);
            animator.SetBool("facingR", true);
            if (rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0)
            {
                animator.SetBool("facingR", false);
            }
        }
    }
}
