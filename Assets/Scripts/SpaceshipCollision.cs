using UnityEngine;

public class SpaceshipCollision : MonoBehaviour
{
    public WordManager wordManager;
    public TextPopupController popupController;
    private float collisionCooldown = 0.2f;  // Duration for cooldown
    private float lastCollisionTime = -10.0f;  // Time of the last collision
    
    
    private void OnCollisionEnter(Collision collision) 
    {
        if (Time.time - lastCollisionTime < collisionCooldown) 
        {
            return;  // Ignore this collision as it's too close to the last one
        }

        lastCollisionTime = Time.time;  // Update the time of the latest collision
    
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