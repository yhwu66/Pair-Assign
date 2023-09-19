using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_button : MonoBehaviour
{
 

    // Update is called once per frame
    public void ChangeToScene(string toChange)
    {
        Application.LoadLevel(toChange);
    }
}
