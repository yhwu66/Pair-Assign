using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextPopupController : MonoBehaviour
{
    public Text popupText;  // Reference to the UI Text component
    public float displayDuration = 1f;  // Duration to display the text

    private void Start()
    {
        // Initially hide the text
        popupText.enabled = false;
    }

    public void ShowPopupMessage(string message)
    {
        popupText.text = message;  // Set the message
        StartCoroutine(ShowAndHideText());  // Start the show/hide sequence
    }

    private IEnumerator ShowAndHideText()
    {
        popupText.enabled = true;  // Show the text
        yield return new WaitForSeconds(displayDuration);  // Wait for specified duration
        popupText.enabled = false;  // Hide the text
    }
}