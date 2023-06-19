using UnityEngine;

public class actuallandingpointmovement : MonoBehaviour
{
    public float speed = 1f;
    public float distance = 1f;

    private Vector3 startPosition;

    private void Start()
    {
        // Store the initial position of the GameObject
        startPosition = transform.localPosition;
    }

    private void Update()
    {
        // Calculate the new X position using Mathf.PingPong function
        float newX = Mathf.PingPong(Time.time * speed, distance);

        // Create a new position vector with the updated X value
        Vector3 newPosition = startPosition + new Vector3(newX, 0f, 0f);

        // Update the local position of the GameObject
        transform.localPosition = newPosition;
    }
}
