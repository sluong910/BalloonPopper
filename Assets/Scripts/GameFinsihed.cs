using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFinsihed : MonoBehaviour
{
    Animator anim;
    private bool setText = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);        
        if (stateInfo.normalizedTime >= 1)
        {
            // Show label           
            if (!setText)
            {
                GameObject go = new GameObject("Child");
                go.AddComponent<RectTransform>();
                go.transform.SetParent(this.transform);                
                go.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
                go.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 1000);
                go.transform.localPosition = new Vector3(0, -380f, 0);                

                go.AddComponent<Text>().text = "TAP TO RETURN TO IRVINE";
                go.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
                go.GetComponent<Text>().fontStyle = FontStyle.Bold;
                go.GetComponent<Text>().color = Color.white;
                go.GetComponent<Text>().fontSize = 70;

                setText = true;
            }            

            if (Input.GetMouseButtonDown(0))            
                SceneManager.LoadScene("Menu");
        }
    }
}
