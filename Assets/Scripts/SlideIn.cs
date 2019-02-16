using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideIn : MonoBehaviour
{
    private bool sirensPlayed = false;

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x;
        if (ManageBalloons.GameFinished && xPos > 0)
        {
            if (!sirensPlayed)
            {
                playSirens();
            }
            transform.Translate(Vector3.left * 0.1f);
        }

        
    }

    void playSirens()
    {
        // FindObjectOfType<AudioManager>().Play("Sirens");
        sirensPlayed = true;
    }
}
