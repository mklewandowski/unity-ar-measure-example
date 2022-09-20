using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ARCursorLineManager : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public TextMeshProUGUI DistanceText;
    public GameObject PointPrefab;
    private GameObject startPoint;
    private GameObject endPoint;

    public void AddLinePoint(Vector3 pointPosition)
    {
        if (lineRenderer.positionCount == 2)
        {
            lineRenderer.positionCount = 0;
            Destroy(startPoint);
            Destroy(endPoint);
            DistanceText.text = "DISTANCE: ";
        }

        // increase point count
        lineRenderer.positionCount++;

        // add point to the line renderer
        lineRenderer.SetPosition(
            lineRenderer.positionCount - 1,
            pointPosition
        );

        if (lineRenderer.positionCount == 1)
            startPoint = GameObject.Instantiate(PointPrefab, pointPosition, Quaternion.identity);
        else
            endPoint = GameObject.Instantiate(PointPrefab, pointPosition, Quaternion.identity);

        // draw a line
        if (lineRenderer.positionCount > 1)
        {
            Vector3 pointA = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
            Vector3 pointB = lineRenderer.GetPosition(lineRenderer.positionCount - 2);
            lineRenderer.SetWidth(.005f, .005f);
            float dist = Vector3.Distance(pointA, pointB);
            float measurementFactor = 39.37f;
            float distInInches = dist * measurementFactor;
            DistanceText.text = "DISTANCE: " + distInInches + " inches";
        }
    }
}
