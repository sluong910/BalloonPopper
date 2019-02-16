using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    public Transform backgroundScroller;
    private Vector3 platformStartPoint;
    private Vector3 backgroundStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;
    // Start is called before the first frame update
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        backgroundStartPoint = backgroundScroller.position;
        playerStartPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        
    }
}
