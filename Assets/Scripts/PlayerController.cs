using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D myRigidBody;

    public bool grounded;
    public LayerMask whatIsGround;

    private CircleCollider2D myCollider;

    private Animator myAnimator;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
            myAnimator.SetFloat("Speed", 2);
        } else
        {
            myRigidBody.velocity = new Vector2(0, myRigidBody.velocity.y);
            myAnimator.SetFloat("Speed", 0);
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
            }
        }

        myAnimator.SetBool("Grounded", grounded);
    }
}
