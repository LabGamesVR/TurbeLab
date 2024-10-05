using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausarTudoM2 : MonoBehaviour
{
    public GameObject dedoInstrucao, somLimpou, somQuebrou, pauseMenu, contagem, somVidroBatendo, somEsfregando;
    public GameObject tubo1, tubo2, tubo3, tubo4, fadeEnd, fadeStart;

    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==true || contagem.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true) {
            tubo1.GetComponent<BoxCollider2D>().enabled=false;
            tubo2.GetComponent<BoxCollider2D>().enabled=false;
            tubo3.GetComponent<BoxCollider2D>().enabled=false;
            tubo4.GetComponent<BoxCollider2D>().enabled=false;
            somVidroBatendo.SetActive(false);
            somEsfregando.SetActive(false);
            somVidroBatendo.SetActive(false);
            somEsfregando.SetActive(false);
        } else {
            tubo1.GetComponent<BoxCollider2D>().enabled=true;
            tubo2.GetComponent<BoxCollider2D>().enabled=true;
            tubo3.GetComponent<BoxCollider2D>().enabled=true;
            tubo4.GetComponent<BoxCollider2D>().enabled=true;
            //somVidroBatendo.SetActive(true);
            //somEsfregando.SetActive(true);
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
        dedoInstrucao.SetActive(true);
    }

}
