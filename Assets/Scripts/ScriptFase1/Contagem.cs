using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contagem : MonoBehaviour
{
    private float tempoInicial = 0;
    public static bool canAnimate = false;
    public GameObject contagem;
    private string texto;
    public GameObject palavra;//, numero1, numero2, numero3;

    // Update is called once per frame
    void Update()
    {
        tempoInicial -= (0.5f*Time.deltaTime);
        if (tempoInicial<=-1){
            palavra.SetActive(false);
            contagem.SetActive(false);
            canAnimate = true;
        }
        if(tempoInicial<0) {
            palavra.SetActive(true);
            //numero1.SetActive(false);
        }
        /*if(tempoInicial>0 && tempoInicial<=1) {
            numero2.SetActive(false);
            numero1.SetActive(true);
        }
        if(tempoInicial>1 && tempoInicial<=2) {
            numero3.SetActive(false);
            numero2.SetActive(true);
        }
        if(tempoInicial>2 && tempoInicial<=3) {
            numero3.SetActive(true);
        }*/
    }
}
