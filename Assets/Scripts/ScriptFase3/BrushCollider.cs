using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushCollider : MonoBehaviour
{
    public int parede;
    private Collider2D col;
    private GameObject[] playerLine;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        playerLine = GameObject.FindGameObjectsWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(parede);
            Debug.Log("Colisão");
        }
    }
}
