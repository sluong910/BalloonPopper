using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float Speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
        else
        {
            // Move the balloons up
            transform.Translate(Vector3.up * Speed);
        }        
    }
}
