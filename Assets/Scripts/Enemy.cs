using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Rigidbody2D myRigidBody;

    public bool touchingPlayer;
    public LayerMask Player;

    private CircleCollider2D myCollider;
    public GameObject thePlayer;
    public PlayerController theController;

    private Animator myAnimator;


    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        thePlayer = GameObject.Find("character");
        theController = FindObjectOfType<PlayerController>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        touchingPlayer = Physics2D.IsTouchingLayers(myCollider, Player);
        if (touchingPlayer)
        {
            //Destroy(thePlayer);
            //Destroy(theController);
            Time.timeScale = 0;
        }
    }
}

