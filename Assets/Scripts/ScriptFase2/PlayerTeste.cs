/*using UnityEngine;
using System.Collections;

public class PlayerTeste : MonoBehaviour {
    // The plane the object is currently being dragged on
    private Plane dragPlane;

    // The difference between where the mouse is on the drag plane and 
    // where the origin of the object is on the drag plane
    private Vector3 offset;

    private Camera myMainCamera; 

    void Start()
    {
        myMainCamera = Camera.main; // Camera.main is expensive ; cache it here
    }

    void OnMouseDown()
    {
        dragPlane = new Plane(myMainCamera.transform.forward, transform.position); 
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition); 

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist); 
        offset = transform.position - camRay.GetPoint(planeDist);
    }

    void OnMouseDrag()
    {   
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition); 

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        transform.position = camRay.GetPoint(planeDist) + offset;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Parede") {
            Debug.Log("Parede");
        }
        
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("Enemy");
            F2pontuacao.pontos -= 25;
        }

        if (collision.gameObject.tag == "Chegada") {
            Debug.Log("Chegada");
        }
    }
}*/

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]

public class PlayerTeste : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;

    public GameObject player;
    public float valor;

    void Update()
    {
        if(Input.GetKey("w")) {
            player.transform.position += new Vector3(0, valor, 0);
        } else if(Input.GetKey("s")) {
            player.transform.position += new Vector3(0, -valor, 0);
        } else if(Input.GetKey("a")) {
            player.transform.position += new Vector3(-valor, 0, 0);
        } else if(Input.GetKey("d")) {
            player.transform.position += new Vector3(valor, 0, 0);
        }
    }

void OnMouseDown() {

    offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
}

void OnMouseDrag()
{
    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    transform.position = curPosition;
}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Parede") {
            Debug.Log("Wall");
        }
        
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("Enemy");
            //F2pontuacao.pontos -= 25;
        }

        if (collision.gameObject.tag == "Finish") {
            Debug.Log("Finish");
        }
    }
}