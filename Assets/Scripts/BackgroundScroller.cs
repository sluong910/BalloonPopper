using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public GameObject theBackGround;
    public Transform generationPoint;

    private float backgroundWidth;

    public ObjectPooler objectPool;

    // Start is called before the first frame update
    void Start()
    {
        backgroundWidth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + backgroundWidth, transform.position.y, transform.position.z);
            // Instantiate(theBackGround, transform.position, transform.rotation);
            GameObject newPlatform = objectPool.GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
        }
    }
}
