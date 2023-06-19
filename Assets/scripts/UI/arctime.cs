using UnityEngine;

public class arctime : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the direction from the UI element to the target
            Vector3 direction = target.position - transform.position;

            // Calculate the rotation needed to face the target point
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.left);

            // Lock the rotation on the Z and Y axes
            Vector3 eulerRotation = targetRotation.eulerAngles;
            eulerRotation.z = 0f;
            eulerRotation.x = 0f;
            targetRotation = Quaternion.Euler(eulerRotation);

            // Apply the rotation to the UI element
            transform.rotation = targetRotation;
        }
    }
}
