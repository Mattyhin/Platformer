using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 5f;
    
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public GroundDetection gd;
    public Animator anim;
    
    public AudioSource audioJump;
    
    void Update()
    {
        anim.SetBool("Running", false);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
            sr.flipX = true;
            
            anim.SetBool("Running", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
            sr.flipX = false;

            anim.SetBool("Running", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && gd.isGrounded)
        {
            //rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            if (audioJump != null)
            {
                audioJump.Play();
            }
        }
        
        anim.SetBool("isGrounded", gd.isGrounded == true);
        anim.SetFloat("SpeedY", rb.velocity.y);
    }
}
