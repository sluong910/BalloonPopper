using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    //AudioSource m_MyAudioSource;

    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;


    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        thePlayer = GameObject.Find("character");
        theController = FindObjectOfType<PlayerController>();
        myAnimator = GetComponent<Animator>();
        //m_MyAudioSource = GetComponent<AudioSource>();
        AudioSource[] audioSources = GetComponents<AudioSource>();
        source = audioSources[0];
        clip1 = audioSources[0].clip;
        clip2 = audioSources[1].clip;
        source.PlayOneShot(clip1);
        source.PlayOneShot(clip2);
    }

    void Update()
    {
        speed = 6 + 0.1f + (Score.CurrentScore / 5.0f);
        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        touchingPlayer = Physics2D.IsTouchingLayers(myCollider, Player);
        if (touchingPlayer)
        {
            //Destroy(thePlayer);
            //Destroy(theController);
            //m_MyAudioSource.Stop();
            source.Stop();
            SceneManager.LoadScene("EndScene");
        } else if (thePlayer.transform.position.x < transform.position.x - 3)
        {
            //m_MyAudioSource.Stop();
            SceneManager.LoadScene("EndScene");
        }
    }
}

