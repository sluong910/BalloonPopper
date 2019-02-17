using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbgm : MonoBehaviour
{
    public AudioManager audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.Play("bgm");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
