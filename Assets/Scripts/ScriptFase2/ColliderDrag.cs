using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColliderDrag : MonoBehaviour
{
    public AudioSource somErrou, somAcertou;
    RectTransform rectTransform;
    public GameObject feedBackF2M3, dedoInstrucao, somFaseConcluida, fade, playerSegurar;
    public Camera cam;
    public Transform square;
    public float distanceFromCamera;
    public static float velocity;
    Rigidbody2D rb;
    public bool mouseOver = false, isColliding = false;
    public string scene;
    public Animator estrelas1, fadeRed;
    int timer = 0;
    public float timeleft = 60f;

    // Start is called before the first frame update
    void Start()
    {
        distanceFromCamera = Vector3.Distance(square.position, cam.transform.position);
        rb = square.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0) || isColliding) {
            rb.velocity = Vector3.zero;
        }

        if (timer == 1)
        {
            timeleft -= Time.deltaTime;
        }

        if (timeleft <= 0)
        {
            PassPhase();
        }
    }

    void OnMouseDown() {
        isColliding = false;
    }
    
    void OnMouseOver() {
        mouseOver = true;
    }
    
    void OnMouseExit() {
        mouseOver = false;
    }

    void OnMouseDrag() {
        dedoInstrucao.SetActive(false);
        timer = 1;
        if (mouseOver && !isColliding) {
            Vector3 pos = Input.mousePosition;
            pos.z = distanceFromCamera;
            pos = cam.ScreenToWorldPoint(pos);
            rb.velocity = (pos-square.position)*velocity;
        }
    }

     void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("Enemy");
            fadeRed.SetBool("Damage", true);
            //somErrou.Play();
        }

        if (collision.gameObject.tag == "EnemyFase3") {
            Debug.Log("EnemyFase3");
            fadeRed.SetBool("Damage", true);
            isColliding = true;
            somErrou.Play();
            transform.position = new Vector3(playerSegurar.transform.position.x, playerSegurar.transform.position.y, 0);
        }

        if (collision.gameObject.tag == "Wall") {
            Debug.Log("Wall");
        }

        if (collision.gameObject.tag == "End") {
            somAcertou.Play();
            Debug.Log("End");
            F2pontuacao.pontos += 200;
            somFaseConcluida.SetActive(true);
            estrelas1.SetBool("Stars", true);
            PassPhase();
        }

        if (collision.gameObject.tag == "Respawn") {
            Debug.Log("Respawn");
            Destroy(collision.gameObject);
            F2pontuacao.pontos += 50;
            estrelas1.SetBool("Stars", true);
        }
    }

    void PassPhase() {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase() {
        velocity = 0;
        if(FeedConfig.feedCount>0) {
            feedBackF2M3.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF2M3.SetActive(false);
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        } else {
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        }
    }

}