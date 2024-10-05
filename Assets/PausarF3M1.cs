using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarF3M1 : MonoBehaviour
{
    public GameObject dedoInstrucaoDireita, dedoInstrucaoEsquerda, dedoInstrucaoCima, fadeStart, fadeEnd, contagem, pauseMenu, pilulaAzul, pilulaLaranja, rodaLaranja, rodaAzul, direita, esquerda;

    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem.activeSelf==true || pauseMenu.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true) {
            pilulaLaranja.GetComponent<PolygonCollider2D>().enabled=false;
            pilulaAzul.GetComponent<PolygonCollider2D>().enabled=false;
        } 
        else {
            pilulaLaranja.GetComponent<PolygonCollider2D>().enabled=true;
            pilulaAzul.GetComponent<PolygonCollider2D>().enabled=true;
        }
    }

    void StartPhase() {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
        if(ScriptF3M1.corPilula == 0) { //laranja
            if(rodaLaranja.transform.position == direita.transform.position) {
                dedoInstrucaoDireita.SetActive(true);
            } else {
                dedoInstrucaoEsquerda.SetActive(true);
            }
        }
        
        if (ScriptF3M1.corPilula == 1) { //azul
            if(rodaAzul.transform.position == direita.transform.position) {
                dedoInstrucaoDireita.SetActive(true);
            } else {
                dedoInstrucaoEsquerda.SetActive(true);
            }
        }

        if(ScriptF3M1.corPilula == 2) { ; //rosa
            dedoInstrucaoCima.SetActive(true);
        }

    }
}
