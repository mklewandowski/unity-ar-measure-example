using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using TMPro;

public class LineManager : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public ARPlacementInteractable placementInteractable;
    public TextMeshPro distTextPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // add listener on object placement event
        placementInteractable.objectPlaced.AddListener(DrawLine);
    }

    void DrawLine(ARObjectPlacementEventArgs args)
    {
        // increase point count
        lineRenderer.positionCount++;

        // add point to the line renderer
        lineRenderer.SetPosition(
            lineRenderer.positionCount - 1,
            args.placementObject.transform.position
        );

        // draw a line
        if (lineRenderer.positionCount > 1)
        {
            Vector3 pointA = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
            Vector3 pointB = lineRenderer.GetPosition(lineRenderer.positionCount - 2);
            float dist = Vector3.Distance(pointA, pointB);
            float measurementFactor = 39.37f;
            float distInInches = dist * measurementFactor;
            TextMeshPro distText = Instantiate(distTextPrefab);
            distText.text = distInInches + " inches";
            Vector3 directionVector = (pointB - pointA);
            Vector3 normal = args.placementObject.transform.up;
            Vector3 upd = Vector3.Cross(directionVector, normal).normalized;
            Quaternion rotation = Quaternion.LookRotation(-normal, upd);
            distText.transform.rotation = rotation;
            distText.transform.position = (pointA + directionVector * .5f) + upd * .05f;
        }
    }
}
