using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    public GameObject CursorChildObject;
    public ARRaycastManager RaycastManager;
    public ARCursorLineManager lineManager;

    // Start is called before the first frame update
    void Start()
    {
        CursorChildObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCursor();
    }

    void UpdateCursor()
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(.5f, .5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        RaycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }

    public void AddLinePoint()
    {
        lineManager.AddLinePoint(transform.position);
    }
}
