using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PilulaScript : MonoBehaviour
{
    public GameObject dedoInstrucaoDireita, dedoInstrucaoEsquerda, dedoInstrucaoCima, estrelas, redFade;
    public AudioSource somErrou, somAcertou;
    private Vector3 screenPoint;
    private Vector3 offset;
    public bool isDragable = false, dentroRoda=false, acertou;


    // Start is called before the first frame update
    void Start()
    {
        dentroRoda=false;
    }

    void OnMouseDown() {
        dedoInstrucaoDireita.SetActive(false);
        dedoInstrucaoEsquerda.SetActive(false);
        dedoInstrucaoCima.SetActive(false);
        isDragable = true;
        if(isDragable) {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }
     
    void OnMouseDrag() {
        if(isDragable) {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    void OnMouseUp() {
        if(dentroRoda) {
            if(acertou) {
                estrelas.SetActive(false);
                estrelas.SetActive(true);
                ScriptF3M1.embaralhar=true;
                F3Pontuacao.pontos+=50;
                somAcertou.Play();
                dentroRoda=false;
            } else {
                redFade.SetActive(false);
                redFade.SetActive(true);
                ScriptF3M1.embaralhar=true;
                somErrou.Play();
                dentroRoda=false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ScriptF3M1.corPilula == 0) {
            if (collision.gameObject.tag == "rodaLaranja") {
                acertou=true;
                dentroRoda=true;
            } else if(collision.gameObject.tag == "rodaAzul") {
                acertou=false;
                dentroRoda=true;
            } else if(collision.gameObject.tag == "Lixeira"){
                acertou=false;
                dentroRoda=true;
            }
        } else if (ScriptF3M1.corPilula == 1) {
            if (collision.gameObject.tag == "rodaAzul") {
                acertou=true;
                dentroRoda=true;
            } else if(collision.gameObject.tag == "rodaLaranja"){
                acertou=false;
                dentroRoda=true;
            } else if(collision.gameObject.tag == "Lixeira"){
                acertou=false;
                dentroRoda=true;
            }
        }

        if(IniciarFase3.dificuldade > 2) {
            if(ScriptF3M1.corPilula == 2) {
                if (collision.gameObject.tag == "Lixeira") {
                    acertou=true;
                    dentroRoda=true;
                } else if(collision.gameObject.tag == "rodaAzul") {
                    acertou=false;
                    dentroRoda=true;
                } else if(collision.gameObject.tag == "rodaLaranja") {
                    acertou=false;
                    dentroRoda=true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        acertou=false;
        dentroRoda=false;
    }

}
