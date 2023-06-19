using UnityEngine;
using UnityEngine.EventSystems;

public class LandingPoint : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private RectTransform landingPointRectTransform;

    private void Awake()
    {
        landingPointRectTransform = GetComponent<RectTransform>();
    }

    public void onselected()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        landingPointRectTransform.anchoredPosition += eventData.delta/75;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // This method is called when the user releases the drag

        // Implement any logic or actions you want to perform when the drag ends
        // You can access the final position of the landing point using landingPointRectTransform.anchoredPosition
    }
}
