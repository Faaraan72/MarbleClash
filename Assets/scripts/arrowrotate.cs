using UnityEngine;

public class arrowrotate : MonoBehaviour
{
    public Transform target;
    public Vector3 axisLockRotation = new Vector3(90f, 0f, 0f);

    private void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the direction from the UI element to the target
            Vector3 direction = target.position - transform.position;

            // Calculate the rotation needed to face the target point
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

            // Lock the X and Y rotations
            Quaternion lockedRotation = Quaternion.Euler(axisLockRotation);

            // Combine the rotations
            Quaternion finalRotation = targetRotation * lockedRotation;

            // Apply the rotation to the UI element
            transform.rotation = finalRotation;
        }
    }
}
