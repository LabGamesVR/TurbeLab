using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsfregarTubos : MonoBehaviour
{
    public int direction = 1;
    public Vector2 deltaPosition;
    public float velocidade, velocidadeQuebra2, tempoInicial;
    public AudioSource somQuebrou, somLimpou;
    public GameObject redFade, stars, tuboLimpo, tuboQuebrado, tubo, sujeira, somVidroBatendo, somEsfregando, dedoInstrucao;
    public static float velocidadeQuebra = 3000;
    public bool chacoalhar;
    private Animator TuboAnim;

    //[SerializeField]
    //Animator estrelas1;

    //[SerializeField]
    //Animator fadeRed;

    void Start()
    {
        TuboAnim = GetComponent<Animator>();
    }

    void Update()
    {
        velocidadeQuebra2 = velocidadeQuebra;
        if (tuboQuebrado.activeSelf == true || tuboLimpo.activeSelf == true)
        {
            tubo.transform.rotation = Quaternion.Euler(0, 0, 0);
            chacoalhar = false;
        }

        if (chacoalhar)
        {
            TuboAnim.SetBool("Chacoalhar", true);
            //estrelas1.SetBool("Stars", true);
        } 
        else 
        {
            TuboAnim.SetBool("Chacoalhar", false);
            //estrelas1.SetBool("Stars", false);
        }
    }
    /*IEnumerator Red()
    {
        estrelas1.SetBool("Stars", false);
        fadeRed.SetBool("Damage", true);
        yield return new WaitForSeconds(0.8f);
        fadeRed.SetBool("Damage", false);
        yield return new WaitForSeconds(1);
    }*/

    void OnMouseOver()
    {
        if (Input.touchCount > 0)
        {
            dedoInstrucao.SetActive(false);
            Touch touch = Input.GetTouch(0);


            if (tuboQuebrado.activeSelf == false && tuboLimpo.activeSelf == false)
            {
                somEsfregando.SetActive(true);
                somVidroBatendo.SetActive(true);
                stars.SetActive(true);
            }
            else
            {
                somEsfregando.SetActive(false);
                somVidroBatendo.SetActive(false);
            }

            if (tuboLimpo.activeSelf == false && tuboQuebrado.activeSelf == false && tempoInicial > 0)
            {

                if (velocidade > 0)
                {
                    tempoInicial -= (Time.deltaTime * 0.4f);
                    chacoalhar = true;
                }
                else if (velocidade > 500)
                {
                    chacoalhar = true;
                    tempoInicial -= (Time.deltaTime * 0.6f);
                }
                else
                {
                    chacoalhar = false;
                }

                if (velocidade > velocidadeQuebra)
                {
                    stars.SetActive(false);
                    redFade.SetActive(false);
                    redFade.SetActive(true);
                    //Pontuacao.pontos -= 25;
                    //StartCoroutine("Red");
                    somQuebrou.Play();
                    tuboQuebrado.SetActive(true);
                    tubo.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                    //tubo.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    F1M2Control.i += 1;
                }

                if (tempoInicial <= 0)
                {
                    Pontuacao.pontos += 50;
                    somLimpou.Play();
                    tuboLimpo.SetActive(true);
                    F1M2Control.i += 1;
                }

                sujeira.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, tempoInicial);
                //sujeira.GetComponent<Image>().color = new Color(1f,1f,1f, tempoInicial);

                velocidade = (touch.deltaPosition.magnitude / Time.deltaTime);
            }

        }
        else
        {
            stars.SetActive(false);
            somEsfregando.SetActive(false);
            somVidroBatendo.SetActive(false);
            chacoalhar = false;
            velocidade = 0;
        }
    }

    void OnMouseExit()
    {
        tubo.transform.rotation = Quaternion.Euler(0, 0, 0);
        chacoalhar = false;
    }

}