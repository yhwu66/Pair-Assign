using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begin_but : MonoBehaviour
{

      // Update is called once per frame
    public void ChangeToSceneBegin(string toBegin)
    {
        Application.LoadLevel(toBegin);
    }
}
