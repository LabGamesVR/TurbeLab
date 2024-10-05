using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public bool isDragable = false;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        F2pontuacao.pontos += 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")) {
            player.transform.position += new Vector3(0, 0.01f, 0);
        } else if(Input.GetKey("s")) {
            player.transform.position += new Vector3(0, -0.01f, 0);
        } else if(Input.GetKey("a")) {
            player.transform.position += new Vector3(-0.01f, 0, 0);
        }
        else if(Input.GetKey("d")) {
            player.transform.position += new Vector3(0.01f, 0, 0);
        }
    }

    void OnMouseDown() {
        isDragable = true;
        if(isDragable) {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }
     
    void OnMouseDrag() {
        if(isDragable) {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); // hardcode the y and z for your use
             
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Parede") {
            Debug.Log("Parede");
            isDragable=false;
        }
        
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("Enemy");
            F2pontuacao.pontos -= 25;
        }

        if (collision.gameObject.tag == "Chegada") {
            Debug.Log("Chegada");
        }
    }
}
