using UnityEngine;

public class SpaceshipCollision : MonoBehaviour
{
    public WordManager wordManager;
    public TextPopupController popupController;
    private void OnCollisionEnter(Collision collision) 
    {
    
        if (collision.gameObject.tag.StartsWith("letter_"))
        {
            Debug.Log("Collision with letter " + collision.gameObject.tag[7]);
            if (wordManager.IsValidLetterHit(collision.gameObject.tag[7]))
            {
                Debug.Log("Correct letter hit!");
                popupController.ShowPopupMessage("Success!");
                Destroy(collision.gameObject);
            }
            else
            {
                Debug.Log("Incorrect letter hit!");
                popupController.ShowPopupMessage("Not in current word!");
            }
        }
    }
}