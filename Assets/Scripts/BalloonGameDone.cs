using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonGameDone : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject ZotAlert;
    private int delay = 75;
    private bool alerted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ManageBalloons.GameFinished)
        {
            if (delay > 0)
                delay--;
            else if (delay <= 0 && !alerted)
            {
                alerted = true;
                Vector2 center = new Vector2(-0.3f, -1.84f);
                Instantiate(ZotAlert, center, Quaternion.identity);
                for (int i = 0; i < 3; i++)
                {
                    FindObjectOfType<AudioManager>().Play("Siren");
                }
                // Instantiate a click to continue
                Instantiate(Canvas, new Vector2(0, 0), Quaternion.identity);
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                    // Load next scene
                    return;
            }
        }
    }

    //IEnumerator Alert()
    //{
    //    FindObjectOfType<AudioManager>().Play("Siren");
    //}
}
