using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
private Rigidbody2D myRigidBody;

    public bool touchingPlayer;
    public LayerMask Player;

    private BoxCollider2D myCollider;
    public GameObject thePlayer;
    public PlayerController theController;
    AudioSource m_MyAudioSource;
    bool m_Play;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
        thePlayer = GameObject.Find("character");
        theController = FindObjectOfType<PlayerController>();
        m_MyAudioSource = GetComponent<AudioSource>();
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
        touchingPlayer = Physics2D.IsTouchingLayers(myCollider, Player);
        if (touchingPlayer)
        {
            //transform.position = new Vector3(transform.position.x + 2, thePlayer.transform.position.y, thePlayer.transform.position.z);
            //thePlayer.transform.position = transform.position;
            m_MyAudioSource.Play();
            Score.CurrentScore++;
            gameObject.SetActive(false);
        }
    }
}
