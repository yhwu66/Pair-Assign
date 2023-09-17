
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LettersGenerator : MonoBehaviour
{
    
    public GameObject[] objectPrefab;  // Prefab to be instantiated
    public int minObjects = 1;       // Minimum number of objects to generate
    public int maxObjects = 10;      // Maximum number of objects to generate

    private string[] words = new[] { "cat", "dog", "mouse" };

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
                Instantiate(objectPrefab[index], spawnPosition, Quaternion.identity);
            }
        }
        
    }
}
