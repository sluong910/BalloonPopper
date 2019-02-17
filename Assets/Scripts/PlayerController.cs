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
    public LayerMask Boba;

    public bool touchingBoba;

    private CircleCollider2D myCollider;

    private Animator myAnimator;

    public Transform target;
    public float smoothTime = 0.3F;
    private Vector2 velocity = Vector2.zero;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetMouseButtonDown(0))
        {
            myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
            myAnimator.SetFloat("Speed", 2);
        } else
        {
            //myRigidBody.velocity = new Vector2(0, myRigidBody.velocity.y);
            Vector2 targetPosition = target.TransformPoint(new Vector2(0, transform.position.y));
            transform.position = Vector2.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            myRigidBody.transform.position = transform.position;
            myAnimator.SetFloat("Speed", 0);
        }
        touchingBoba = Physics2D.IsTouchingLayers(myCollider, Boba);
        //if (touchingBoba)
        //{
            //if (myAnimator.GetBool("Power") == true)
            //{
           //     myAnimator.SetBool("Power", false);
            //}
          //  else
           // {
              //  myAnimator.SetBool("Power", true);
           // }
       // }

        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        //{
        //if (grounded)
        //{
        //    myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
        //}
        //}

        //myAnimator.SetBool("Grounded", grounded);
    }
}
