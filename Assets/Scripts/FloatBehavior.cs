using UnityEngine;

public class FloatBehavior : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = initialPosition + amplitude * new Vector3(0, Mathf.Sin(Time.time * frequency), 0);
    }
}