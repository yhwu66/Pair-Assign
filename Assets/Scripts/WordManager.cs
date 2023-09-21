using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public List<string> words = new List<string>() {"cat"};
    public int currentWordIndex = 0;
    public Text displayTextCurrentWord;
    public Text displayTextTimer;
    public Text displayTextWin;
    public TextPopupController popupController;

    private HashSet<char> currentWordSet;
    private float startTime;
    private float finishTime = 0f;
    private List<string> completedWords = new List<string>();

    public void Start()
    {
        Debug.Log("Current word: " +  words[0]);
        currentWordSet = new HashSet<char>(words[0]);
        displayTextCurrentWord.text = "Completed Words : ";
        displayTextWin.text = "You Win!";
        displayTextWin.enabled = false;
        //displayTextTimer.enabled = false;
        startTime = Time.time;
        
        
    }

    public void Update()
    {
        float t = Time.time - startTime;
        string seconds = (t % 60).ToString("f2");
        displayTextTimer.text = "Time: " + seconds + "s";
    }


    public string GetCurrentWord()
    {
        return words[currentWordIndex];
    }
    
    public bool IsValidLetterHit(char letter)
    {
        if (currentWordSet.Contains(letter))
        {
            popupController.ShowPopupMessage("Success!");
            currentWordSet.Remove(letter);
            if (currentWordSet.Count == 0)
            {
                HandleWordCompletion();
                completedWords.Add(words[currentWordIndex-1]);
                displayTextCurrentWord.text += words[currentWordIndex-1] + " ";
            }
            
            return true;
        }
        popupController.ShowPopupMessage("Not in current word!");
        return false;
    }

    private void HandleWordCompletion()
    {
        Debug.Log("Word Completed: " + words[currentWordIndex]);
        currentWordIndex++;
        popupController.ShowPopupMessage(words[currentWordIndex-1] + " completed!");
        

        // Check if we have more words
        if (currentWordIndex < words.Count){
            Debug.Log("Current word: " +  words[currentWordIndex]);
            currentWordSet = new HashSet<char>(words[currentWordIndex]);
        }
        else
        {
            Debug.Log("All words completed! You win!");
            displayTextWin.enabled = true;
            finishTime = Time.time - startTime;
            string seconds = (finishTime % 60).ToString("f2");
            
            if (DataManagerSingleton.Instance != null)
            {
                DataManagerSingleton.Instance.SetFinalTime(seconds);
            }
            
            SceneManager.LoadScene("GameOver");
        }
    }
    
}