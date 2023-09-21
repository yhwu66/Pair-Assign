using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        if (DataManagerSingleton.Instance != null)
        {
            scoreText.text = "Final Time " + DataManagerSingleton.Instance.finalTimeStr + " seconds";
        }
        else
        {
            scoreText.text = "Score data missing!";
        }
    }
}
