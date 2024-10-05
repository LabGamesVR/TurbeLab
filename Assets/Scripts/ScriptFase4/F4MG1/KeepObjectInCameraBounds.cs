using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepObjectInCameraBounds : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 objectSize;

    private void Start()
    {
        mainCamera = Camera.main;
        objectSize = GetComponent<Renderer>().bounds.extents;
    }

    private void Update()
    {
        // Limitar a posição do objeto à área visível da câmera
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, mainCamera.ViewportToWorldPoint(Vector3.zero).x + objectSize.x, mainCamera.ViewportToWorldPoint(Vector3.one).x - objectSize.x);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, mainCamera.ViewportToWorldPoint(Vector3.zero).y + objectSize.y, mainCamera.ViewportToWorldPoint(Vector3.one).y - objectSize.y);
        transform.position = clampedPosition;
    }
}
