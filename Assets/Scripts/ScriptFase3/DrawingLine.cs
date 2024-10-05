using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingLine : MonoBehaviour
{
    public GameObject linePrefab;

    [Space(30f)]
    public Gradient lineColor;
    public float linePointsMinDistance;
    public float lineWidth;
    public GameObject timer;
    public List<PathDraw> Lines = new List<PathDraw>();

    public GameObject Dedo1, Dedo2, Dedo3;
    PathDraw currentLine;

    public int countLines = 0;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BeginDraw();
        }

        if(currentLine != null)
        {
            Draw();
        }

        if (Input.GetMouseButtonUp(0))
        {
            EndDraw();
        }
        if(countLines >= 2)
        {
            Destroy(Lines[countLines-2].gameObject);
        }
    }

    void BeginDraw()
    {
        timer.SetActive(true);
        currentLine = Instantiate(linePrefab, this.transform).GetComponent<PathDraw>();

        Dedo1.SetActive(false);
        Dedo2.SetActive(false);
        Dedo3.SetActive(false);

        currentLine.UsePhysics(false);
        currentLine.SetLineColor(lineColor);
        currentLine.SetPointsMinDistance(linePointsMinDistance);
        currentLine.SetLineWidth(lineWidth);

        Lines.Add(currentLine);
        countLines++;
    }

    void Draw()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        currentLine.AddPoint(mousePosition);
    }

    void EndDraw()
    {
        if(currentLine != null)
        {
            if(currentLine.pointsCount < 2)
            {
                Destroy(currentLine.gameObject);
            }
            else
            {
                //currentLine.UsePhysics(true);
                currentLine = null;
            }
        }
    }
}
