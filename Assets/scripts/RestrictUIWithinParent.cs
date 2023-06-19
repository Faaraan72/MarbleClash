using UnityEngine;
using UnityEngine.EventSystems;

public class RestrictUIWithinParent : MonoBehaviour, IDragHandler
{
    private RectTransform uiRectTransform;
    private RectTransform parentRectTransform;

    private void Awake()
    {
        uiRectTransform = GetComponent<RectTransform>();
        parentRectTransform = transform.parent.GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localCursor;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform, eventData.position, eventData.pressEventCamera, out localCursor))
        {
            Vector2 clampedPosition = ClampPosition(localCursor);
            uiRectTransform.localPosition = clampedPosition;
        }
    }

    private Vector2 ClampPosition(Vector2 position)
    {
        Vector2 parentSize = parentRectTransform.rect.size;
        Vector2 minClamp = parentRectTransform.rect.min - uiRectTransform.rect.min;
        Vector2 maxClamp = parentSize - uiRectTransform.rect.size + minClamp;
        return new Vector2(
            Mathf.Clamp(position.x, minClamp.x, maxClamp.x),
            Mathf.Clamp(position.y, minClamp.y, maxClamp.y)
        );
    }
}
