

using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LettersGenerator : MonoBehaviour
{
    
    public GameObject[] objectPrefab;  // Prefab to be instantiated

    private string[] words = new[] { "cat", "dog", "mouse" };
    private List<GameObject> letters = new List<GameObject>();

    void Start()
    {
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                float randomX = Random.Range(-100f, 100f);  // Adjust the range as needed
                float randomY = Random.Range(-100f, 100f);    // Adjust the range as needed
            
                Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
                int index = c - 'a';
                
                float randomRotationX = Random.Range(0f, 360f);
                float randomRotationY = Random.Range(0f, 360f);
                float randomRotationZ = Random.Range(0f, 360f);
                Quaternion rotation = Quaternion.Euler(randomRotationX, randomRotationY, randomRotationZ);
                
                GameObject newLetter = Instantiate(objectPrefab[index], spawnPosition, rotation);
                newLetter.tag = "letter_"+c;
                letters.Add(newLetter);
            }
        }
        
    }
    
    public List<GameObject> GetLetters()
    {
        return letters;
    }
}
