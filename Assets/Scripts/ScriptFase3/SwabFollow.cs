using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwabFollow : MonoBehaviour
{
    Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.localPosition = mousePosition;
    }
}
