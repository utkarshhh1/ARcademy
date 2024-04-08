using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intraction : MonoBehaviour
{
    // Parameters for zooming
    public float zoomSpeed = 0.5f;
    public float minZoom = 0.5f;
    public float maxZoom = 5f;

    // Parameters for rotating
    public float rotationSpeed = 2f;

    private Camera mainCamera;
    private bool isDragging = false;
    private Vector2 lastPosition;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Check for touch input
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // Zoom
            if (touch.phase == TouchPhase.Moved)
            {
                float zoomDelta = touch.deltaPosition.y * zoomSpeed * Time.deltaTime;
                ZoomObject(zoomDelta);
            }

            // Rotate
            if (touch.phase == TouchPhase.Began)
            {
                isDragging = true;
                lastPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                Vector2 delta = touch.position - lastPosition;
                RotateObject(delta.x);
                lastPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isDragging = false;
            }
        }
    }

    void ZoomObject(float delta)
    {
        Vector3 scale = transform.localScale;
        float newSize = Mathf.Clamp(scale.x - delta, minZoom, maxZoom);
        transform.localScale = new Vector3(newSize, newSize, newSize);
    }

    void RotateObject(float delta)
    {
        transform.Rotate(Vector3.up, -delta * rotationSpeed);
    }
}
