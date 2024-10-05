using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausarTudoM3 : MonoBehaviour
{
    public GameObject script, pauseMenu, contagem;
    public string scene;
    public float tempoInicial = 0;
    public GameObject tubo1Inativo, tubo2Inativo, tubo3Inativo, tubo4Inativo;
    public GameObject tubo1Ativo, tubo2Ativo, tubo3Ativo, tubo4Ativo, fadeEnd, fadeStart;

    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==true || contagem.activeSelf==true || fadeStart.activeSelf==true) 
        {
            tubo1Inativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo2Inativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo3Inativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo4Inativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo1Ativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo2Ativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo3Ativo.GetComponent<BoxCollider2D>().enabled=false;
            tubo4Ativo.GetComponent<BoxCollider2D>().enabled=false;
        } 
        else 
        {
            tubo1Inativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo2Inativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo3Inativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo4Inativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo1Ativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo2Ativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo3Ativo.GetComponent<BoxCollider2D>().enabled=true;
            tubo4Ativo.GetComponent<BoxCollider2D>().enabled=true;
        }
        
    }

    void StartPhase() 
    {
        StartCoroutine("FadeStart");
    }

    void ComecarExplosoes1() {
        StartCoroutine("ComecarExplosoes");
    }
    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
        script.GetComponent<ExplosaoScript>().enabled=true;
    }
    
}
