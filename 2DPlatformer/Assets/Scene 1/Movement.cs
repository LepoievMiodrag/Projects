using UnityEngine;
using System.Collections;
using System;

public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public Animator anim;

    public Transform groundCheck;
    public Transform LeftWallCheck;
    public Transform RightWallCheck;
    public Transform RightSlopeCheck;
    public Transform LeftSlopeCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public LayerMask RightSlope;
    public LayerMask LeftSlope;
    private bool grounded;
    public bool isJumping=false;
    //public bool leftwall;
    public bool rightwall;
    private bool leftslope;
    private bool rightslope;
    private bool m_FacingRight = true;
    public bool walled = false;
    public int rightmovement;
    public int leftmovement;

    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        //leftwall = Physics2D.OverlapCircle(LeftWallCheck.position, groundCheckRadius, whatIsGround);
        rightwall = Physics2D.OverlapCircle(RightWallCheck.position, groundCheckRadius, whatIsGround);
        leftslope = Physics2D.OverlapCircle(LeftSlopeCheck.position, groundCheckRadius, LeftSlope);
        rightslope = Physics2D.OverlapCircle(RightSlopeCheck.position, groundCheckRadius, RightSlope);
        if(rightwall == true)
        {
            walled = true;
        }
        else
        {
            walled = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            SoundManager.PlaySound("jump");
        }
        if (rightwall == true && grounded == false && Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.transform.localScale.x == -1)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 120);
                SoundManager.PlaySound("jump");
                GetComponent<Rigidbody2D>().velocity = new Vector2(60, GetComponent<Rigidbody2D>().velocity.y);
                Flip();
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 120);
                SoundManager.PlaySound("jump");
                GetComponent<Rigidbody2D>().velocity = new Vector2(-60, GetComponent<Rigidbody2D>().velocity.y);
                Flip();
            }

            


        }

        if (isJumping == true)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        if(grounded == true || leftslope == true || rightslope == true)
        {
            isJumping = false;
            anim.SetBool("Grounded", true);
        }
        else
        {
            isJumping = true;
            anim.SetBool("Grounded", false);
        }
        
        if(rightwall == true)
        {
            anim.SetBool("WallGrab", true);
        }
        else
        {
            anim.SetBool("WallGrab", false);
        }

        //if(leftwall == true)
       // {
        //    isJumping = false;
        //}

        if(rightwall == true)
        {
            isJumping = false;
            grounded = true;
        }

        if (rightwall == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 20;
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -25);
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 20;
        }

        if (walled == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                if (m_FacingRight == false)
                {
                    Flip();
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (m_FacingRight == true)
                {
                    Flip();
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                anim.SetFloat("Speed", 1);
            }
            else
            {
                anim.SetFloat("Speed", 0);
            }
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}