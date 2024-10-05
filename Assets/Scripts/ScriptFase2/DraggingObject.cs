using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DraggingObject : MonoBehaviour
{
    public AudioSource somAcertou, somErrou;
    private Vector3 screenPoint;
    private Vector3 offset;
    public Camera cam;
    public Transform square;
    public float distanceFromCamera, velocity = 25;
    Rigidbody2D rb;
    public bool mouseOver = false, isColliding = false, isDragable = false;
    public string scene;
    public SpriteRenderer spritePlayer, spriteAnim;
    public GameObject playerSegurar, somComendo, somFaseCompletada, fadeEnd, player, player2, dedoInstrucao, pontilhadoInstrucao, feedBackF2M1;
    private Animator playerAnim;
    public Animator fadeRed, estrelas1;
    int count = 0, timer = 0;
    public float timeleft = 30f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        distanceFromCamera = Vector3.Distance(square.position, cam.transform.position);
        rb = square.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IniciarFase2.dificuldade == 1)
        {
            scene = "Fase2M2";
        }
        if (IniciarFase2.dificuldade > 1)
        {
            scene = "Fase2M2";
        }
        if (Input.GetMouseButtonUp(0) || isColliding)
        {
            rb.velocity = Vector3.zero;
        }
        if (GameObject.FindGameObjectsWithTag("Respawn").Length <= 0)
        {
            somFaseCompletada.SetActive(true);
            PassPhase();
        }

        if(timer == 1)
        {
            timeleft -= Time.deltaTime;
        }

        if (timeleft <= 0)
        {
            PassPhase();
        }
    }

    void OnMouseDown()
    {
        isDragable = true;
        if (isDragable && count == 0)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        dedoInstrucao.SetActive(false);
        pontilhadoInstrucao.SetActive(false);
        timer = 1;
        if (isDragable && count == 0)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    /*void OnMouseOver()
    {
        mouseOver = true;
    }

    void OnMouseExit()
    {
        mouseOver = false;
    }

    void OnMouseDown() {
        isDragable=true;
    }

    void OnMouseDrag()
    {
        dedoInstrucao.SetActive(false);
        if (mouseOver && !isColliding && isDragable)
        {
            Vector3 pos = Input.mousePosition;
            pos.z = distanceFromCamera;
            pos = cam.ScreenToWorldPoint(pos);
            rb.velocity = (pos - square.position) * velocity;
        }
    }*/
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            somErrou.Play();
            count = 1;
            isDragable = false;
            Debug.Log("Enemy");
            //player.transform.position = playerSegurar.transform.position;
            player.transform.position = new Vector3(-1.29f, 0, 1);
            playerAnim.SetBool("Damage", true);
            StartCoroutine("Hit");
            StartCoroutine("Red");
        }

        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Wall");
        }

        if (collision.gameObject.tag == "Respawn")
        {
            somAcertou.Play();
            Debug.Log("Respawn");
            Destroy(collision.gameObject);
            F2pontuacao.pontos += 50;
            somComendo.SetActive(true);
            Comer();
            StartCoroutine("Stars");
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        isColliding = false;
        somComendo.SetActive(false);
    }

    void PassPhase()
    {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase()
    {
        velocity = 0;
        if(FeedConfig.feedCount>0) {
            feedBackF2M1.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF2M1.SetActive(false);
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        } else {
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        }
    }

    IEnumerator Hit()
    {
        yield return new WaitForSeconds(1f);
        count = 0;
    }

    void Comer()
    {
        StartCoroutine("Comendo");
    }

    public void damagefalse()
    {
        playerAnim.SetBool("Damage", false);
    }

    IEnumerator Comendo()
    {
        spritePlayer.enabled = false;
        spriteAnim.color = new Color(1, 1, 1, 1);
        //player.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        //player2.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.2f);
        spritePlayer.enabled = true;
        spriteAnim.color = new Color(1, 1, 1, 0);
        //player.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        //player2.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    IEnumerator Stars()
    {
        estrelas1.SetBool("Stars", true);
        fadeRed.SetBool("Damage", false);
        yield return new WaitForSeconds(2.5f);
        estrelas1.SetBool("Stars", false);
        fadeRed.SetBool("Damage", false);
        yield return new WaitForSeconds(1);
    }

    IEnumerator Red()
    {
        estrelas1.SetBool("Stars", false);
        fadeRed.SetBool("Damage", true);
        yield return new WaitForSeconds(0.8f);
        fadeRed.SetBool("Damage", false);
        yield return new WaitForSeconds(1);
    }
}
