using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalloonGameDone : MonoBehaviour
{    
    public GameObject Canvas;
    public GameObject ZotAlert;
    private int delay = 300;
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
            if (!alerted)
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
            if (Input.GetMouseButtonDown(0) && delay <= 0)
                SceneManager.LoadScene("police_chase_instruction");
            else
                delay--;
        }
    }

    //IEnumerator Alert()
    //{
    //    FindObjectOfType<AudioManager>().Play("Siren");
    //}
}
