using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public LettersGenerator lettersGenerator;
    public Color newColor = Color.red;  // Default color to change to. You can adjust this in the Inspector.

    public void ChangeColorOfLetters()
    {
        List<GameObject> objectsFromGenerator = lettersGenerator.GetLetters();
        foreach (GameObject obj in objectsFromGenerator)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = newColor;
            }
        }
    }
}