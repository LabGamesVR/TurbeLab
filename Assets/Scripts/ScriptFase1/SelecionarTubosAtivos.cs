using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecionarTubosAtivos : MonoBehaviour
{
    //public Animator explodir;
    public GameObject star, explosao, tuboAtivo, dedo;
    public AudioSource somClicarTubo;
    //public Animator estrelas1;


    // Update is called once per frame
    void Update()
    {
        if(ExplosaoScript.dedo==0) {
            dedo.SetActive(true);
        }
    }

    void OnMouseDown() {
        ExplosaoScript.i++;
        explosao.SetActive(false);
        explosao.SetActive(true);
        tuboAtivo.SetActive(false);
        Pontuacao.pontos += 50;
        star.SetActive(false);
        star.SetActive(true);
        //estrelas1.SetBool("Stars", true);
        somClicarTubo.Play();
        ExplosaoScript.cliques+=1;
        dedo.SetActive(false);
        ExplosaoScript.dedo=1;
    }
}
