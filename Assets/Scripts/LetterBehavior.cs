using UnityEngine;

public class LetterBehavior : MonoBehaviour
{
    public float moveSpeed = 3.0f;     // Speed of primary movement
    public float floatSpeed = 1.0f;    // Speed of the floating motion
    public float floatAmount = 0.5f;   // Magnitude of the floating motion

    private Vector3 moveDirection;     // The primary direction of movement
    private Vector3 floatDirection;    // The orthogonal direction for floating
    private Vector3 basePosition;      // The letter's intended position without the floating effect

    private void Start()
    {
        SetRandomDirection();
        basePosition = transform.position;
    }

    private void Update()
    {
        basePosition += moveDirection * moveSpeed * Time.deltaTime;
        ApplyFloating();
    }

    private void SetRandomDirection()
    {
        moveDirection = Random.onUnitSphere;
        floatDirection = Vector3.Cross(moveDirection, Random.onUnitSphere).normalized; 
    }

    private void ApplyFloating()
    {
        float floatingValue = Mathf.Sin(Time.time * floatSpeed) * floatAmount;
        Vector3 floatOffset = floatDirection * floatingValue;
        transform.position = basePosition + floatOffset;
    }
}