using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busted : MonoBehaviour
{
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playSoundAfterDelay());        
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator playSoundAfterDelay()
    {
        yield return new WaitForSeconds(7.2f);
        audiosource.Play();
        yield return new WaitForSeconds(.5f);
        audiosource.Play();
        yield return new WaitForSeconds(.5f);
        audiosource.Play();
        yield return new WaitForSeconds(.5f);
        audiosource.Play();
    }
}
