

using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LettersGenerator : MonoBehaviour
{
    
    public GameObject[] objectPrefab;  // Prefab to be instantiated
    public WordManager wordManager;

    
    private List<GameObject> letters = new List<GameObject>();
    private float range = 20f;
    private float scale = 4f;

    void Start()
    {
        List<string> words = wordManager.words;
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                float randomX = Random.Range(-range, range); 
                float randomY = Random.Range(-range, range); 
                float randomZ = Random.Range(-range, range);
            
                Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);
                int index = c - 'a';
                
                float randomRotationX = Random.Range(0f, 360f);
                float randomRotationY = Random.Range(0f, 360f);
                float randomRotationZ = Random.Range(0f, 360f);
                Quaternion rotation = Quaternion.Euler(randomRotationX, randomRotationY, randomRotationZ);
                
                GameObject newLetter = Instantiate(objectPrefab[index], spawnPosition, rotation);
                Vector3 spawnScale = new Vector3(scale, scale, scale);
                newLetter.transform.localScale = spawnScale;
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
