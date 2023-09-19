using UnityEngine;
using System.Collections.Generic;

public class WordManager : MonoBehaviour
{
    public List<string> words = new List<string>() { "cat", "dog"};
    public int currentWordIndex = 0;

    private HashSet<char> currentWordSet;

    public void Start()
    {
        Debug.Log("Current word: " +  words[0]);
        currentWordSet = new HashSet<char>(words[0]);
    }


    public string GetCurrentWord()
    {
        return words[currentWordIndex];
    }
    
    public bool IsValidLetterHit(char letter)
    {

        if (currentWordSet.Contains(letter))
        {
            currentWordSet.Remove(letter);
            if (currentWordSet.Count == 0)
            {
                HandleWordCompletion();
            }
            return true;
        }
        
        return false;
    }

    private void HandleWordCompletion()
    {
        Debug.Log("Word Completed: " + words[currentWordIndex]);
        currentWordIndex++;

        // Check if we have more words
        if (currentWordIndex < words.Count){
            Debug.Log("Current word: " +  words[currentWordIndex]);
            currentWordSet = new HashSet<char>(words[currentWordIndex]);
        }
        else
        {
            Debug.Log("All words completed! You win!");
            
        }
    }
}