
using UnityEngine;

public class TRenderer : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public int numPoints = 50;
    public float arcHeight = 1f;
    public Transform landingpt;
    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Start()
    {
        startPoint.position = transform.position;
        endPoint.position = landingpt.position;
    }

    private void Update()
    {
        DrawTrajectory();
    }

    private void DrawTrajectory()
    {
        lineRenderer.positionCount = numPoints;

        for (int i = 0; i < numPoints; i++)
        {
            float t = i / (float)(numPoints - 1);
            lineRenderer.SetPosition(i, CalculatePointOnArc(t));
        }
    }

    private Vector3 CalculatePointOnArc(float t)
    {
        float x = Mathf.Lerp(startPoint.position.x, endPoint.position.x, t);
        float y = Mathf.Lerp(startPoint.position.y, endPoint.position.y, t) + arcHeight * Mathf.Sin(t * Mathf.PI);
        float z = Mathf.Lerp(startPoint.position.z, endPoint.position.z, t);

        return new Vector3(x, y, z);
    }
}
