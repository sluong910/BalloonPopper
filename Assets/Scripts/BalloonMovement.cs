using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 10)
        {
            Destroy(gameObject);
        }
        else
        {
            // Move the balloons up
            float Speed = 0.1f + (Score.CurrentScore / 500.0f);
            transform.Translate(Vector3.up * Speed);
        }        
    }
}
