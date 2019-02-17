using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int CurrentScore;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScore = 0;
    }

    public void OnGUI()
    {
        GUI.skin.label.fontSize = 24;
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(20, 20, 150, 50), "Score: " + CurrentScore);
    }
}
