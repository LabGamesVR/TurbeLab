using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptF3M1 : MonoBehaviour
{
    public static int corPilula; //0=laranja, 1=azul
    public static bool embaralhar = false;
    int cor, posicaoRoda, i;
    public GameObject meio, pilulaPodre, pilulaLaranja, pilulaAzul, Lixeira, rodaLaranja, rodaAzul, direita, esquerda, fadeEnd, somFaseCompletada, feedBackF3M1;

    // Start is called before the first frame update
    void Start()
    {
        if(IniciarFase3.dificuldade < 3) {
            cor = Random.Range(0, 4);
            Lixeira.SetActive(false);
            pilulaPodre.SetActive(false);
        } else {
            cor = Random.Range(0, 6);
            Lixeira.SetActive(true);
            pilulaPodre.SetActive(true);
        }
        posicaoRoda = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update() {
        if(embaralhar) {
            StartCoroutine("Embaralhar");
            embaralhar=false;
            i++;
        }

        if(i>4) {
            somFaseCompletada.SetActive(true);
            StartCoroutine("PassPhase");
        }

        if(posicaoRoda==0 || posicaoRoda==1) {
            rodaLaranja.transform.position = direita.transform.position;
            rodaAzul.transform.position = esquerda.transform.position;
        } else {
            rodaLaranja.transform.position = esquerda.transform.position;
            rodaAzul.transform.position = direita.transform.position;
        }

        if(cor==0 || cor==1) {
            corPilula=0;
            pilulaLaranja.SetActive(true);
            pilulaAzul.SetActive(false);
            pilulaPodre.SetActive(false);
        } else if (cor==2 || cor == 3) {
            corPilula=1;
            pilulaLaranja.SetActive(false);
            pilulaAzul.SetActive(true);
            pilulaPodre.SetActive(false);
        } else if( cor==4 || cor==5) {
            corPilula=2;
            pilulaLaranja.SetActive(false);
            pilulaAzul.SetActive(false);
            pilulaPodre.SetActive(true);
        }
    }

    IEnumerator PassPhase() {
        if(FeedConfig.feedCount>0) {
            feedBackF3M1.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF3M1.SetActive(false);
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Fase3M2");
        } else {
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Fase3M2");
        }
    }


    IEnumerator Embaralhar() {
        yield return new WaitForSeconds(0.1f);
        if(IniciarFase3.dificuldade < 3) {
            cor = Random.Range(0, 4);
        } else {
            cor = Random.Range(0, 6);
        }
        if(IniciarFase3.dificuldade > 1) {
            posicaoRoda = Random.Range(0, 4);
        }
        pilulaAzul.transform.position = meio.transform.position;
        pilulaLaranja.transform.position = meio.transform.position;
        if(IniciarFase3.dificuldade > 2) {
            pilulaPodre.transform.position = meio.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(corPilula == 0) {
            if (collision.gameObject.tag == "rodaLaranja") {
                Debug.Log("pilulaLaranja na rodaLaranja");
            } else {
                Debug.Log("pilulaLaranja na rodaAzul");
            }
        } else {
            if (collision.gameObject.tag == "rodaAzul") {
                Debug.Log("piluAzul na rodaAzul");
            } else {
                Debug.Log("pilulaAzul na rodaLaranja");
            }
        }
    }
}
