using UnityEngine;
using UnityEngine.EventSystems;

public class SelectLandingPoint : MonoBehaviour
{
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object has a landing point script
                LandingPoint landingPoint = hit.collider.GetComponent<LandingPoint>();
                if (landingPoint != null)
                {
                    // Call a method on the landing point script to handle the selection
                    landingPoint.onselected();
                }
            }
        }
    }
}
