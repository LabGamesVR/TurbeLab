using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IniciarFase1 : MonoBehaviour
{
    public GameObject facil, medio, dificil;

    public static int easy, medium, hard;

    public string scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Pontuacao.pontos = 0;
        if (facil.activeSelf == true)
        {
            EsfregarTubos.velocidadeQuebra = 4000;
            LinhaScript.tempoChange = 7f;
            ExplosaoScript.quantidade = 3;
            FinalizarFase1.dificuldade = 1;
            easy = 1;
            medium = 0;
            hard = 0;
            //scene="InstrucaoM1";
        }
        if (medio.activeSelf == true)
        {
            EsfregarTubos.velocidadeQuebra = 3500;
            LinhaScript.tempoChange = 5f;
            ExplosaoScript.quantidade = 4;
            FinalizarFase1.dificuldade = 2;
            medium = 1;
            easy = 0;
            hard = 0;
            //scene="Fase1Minigame1";
        }
        if (dificil.activeSelf == true)
        {
            EsfregarTubos.velocidadeQuebra = 3000;
            LinhaScript.tempoChange = 3f;
            ExplosaoScript.quantidade = 5;
            FinalizarFase1.dificuldade = 3;
            hard = 1;
            easy = 0;
            medium = 0;
            //scene="Fase1Minigame1";
        }
        if (facil.activeSelf == true || medio.activeSelf == true || dificil.activeSelf == true)
        {
            SceneManager.LoadScene("Fase1Minigame1");
        }
    }
}