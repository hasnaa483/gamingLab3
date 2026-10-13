using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera cam;
    public float zoomSpeed=3;
    private float TargetZoom;
    private float ScrollData;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        TargetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData = Input.GetAxis("Mouse ScrollWheel");
        TargetZoom = TargetZoom - ScrollData;
        TargetZoom = Mathf.Clamp(TargetZoom, 3,6);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, TargetZoom, Time.deltaTime * zoomSpeed);
    }
}
