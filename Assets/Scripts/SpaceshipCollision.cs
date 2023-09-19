using UnityEngine;

public class SpaceshipCollision : MonoBehaviour
{
    public WordManager wordManager;
    private void OnCollisionEnter(Collision collision) 
    {
    
        if (collision.gameObject.tag.StartsWith("letter_"))
        {
            Debug.Log("Collision with letter " + collision.gameObject.tag[7]);
            if (wordManager.IsValidLetterHit(collision.gameObject.tag[7]))
            {
                Debug.Log("Correct letter hit!");
                Destroy(collision.gameObject);
            }
            else
            {
                Debug.Log("Incorrect letter hit!");
            }
        }
    }
}