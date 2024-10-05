using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDraw : MonoBehaviour
{
    public EdgeCollider2D _edgeCollider2D;
    public Rigidbody2D rb;

    [HideInInspector] public List<Vector2> points = new List<Vector2>();
    [HideInInspector] public int pointsCount = 0;

    public F3M2Controller F3M2C;

    public LineRenderer _lineRenderer;

    float pointsMinDistance = 0.1f;

    private void Start()
    {
        F3M2C = GameObject.FindGameObjectWithTag("GameController").GetComponent<F3M2Controller>();
    }
    public void AddPoint(Vector2 newPoint)
    {
        if(pointsCount >= 1 && Vector2.Distance (newPoint, GetLastPoint()) < pointsMinDistance)
        {
            return;
        }

        F3M2C.Stars();

        points.Add(newPoint);
        pointsCount++;

        _lineRenderer.positionCount = pointsCount;
        _lineRenderer.SetPosition(pointsCount - 1, newPoint);

        if(pointsCount > 1)
        {
            _edgeCollider2D.points = points.ToArray();
        }
    }

    public Vector2 GetLastPoint()
    {
        return (Vector2)_lineRenderer.GetPosition(pointsCount - 1);
    }

    public void UsePhysics(bool usePhysics)
    {
        rb.isKinematic = !usePhysics;
    }

    public void SetLineColor(Gradient colorGradient)
    {
        _lineRenderer.colorGradient = colorGradient;
    }
    
    public void SetPointsMinDistance(float distance)
    {
        pointsMinDistance = distance;
    }

    public void SetLineWidth(float width)
    {
        _lineRenderer.startWidth = width;
        _lineRenderer.endWidth = width;

        _edgeCollider2D.edgeRadius = width / 2f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            F3M2C.RedFade();
            Destroy(this.gameObject);
        }

        else if(collision.gameObject.tag == "End")
        {
            F3M2C.NextScene();
            if (IniciarFase3.easy == 1)
            {
                F3Pontuacao.pontos += 200;
            }
            else if (IniciarFase3.medium == 1)
            {
                F3Pontuacao.pontos += 200;
            }
            else if (IniciarFase3.hard == 1)
            {
                F3Pontuacao.pontos += 200;
            }
            Destroy(this.gameObject);
        }
    }
}