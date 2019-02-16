using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaGenerator : MonoBehaviour
{
    public GameObject theBoba;
    public Transform generationPoint;

    public float distanceBetween;

    public ObjectPooler objectPool;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + distanceBetween, transform.position.y, transform.position.z + 15);
            // Instantiate(thePlatform, transform.position, transform.rotation);
            GameObject newPlatform = objectPool.GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
        }
    }
}
