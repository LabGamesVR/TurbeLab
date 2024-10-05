using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnMouseDown() {
        Time.timeScale=1;
        if(FinalizarFase1.dificuldade==1) {
            EsfregarTubos.velocidadeQuebra = 2500;
            LinhaScript.tempoChange = 7f;
            ExplosaoScript.quantidade = 3;
            FinalizarFase1.dificuldade = 1;
            FinalizarFase1.dificuldadeF1Completada = 1;
            scene = "Fase1Minigame1";
        }
        if(FinalizarFase1.dificuldade==2) {
            EsfregarTubos.velocidadeQuebra = 2000;
            LinhaScript.tempoChange = 5f;
            ExplosaoScript.quantidade = 4;
            FinalizarFase1.dificuldade = 2;
            FinalizarFase1.dificuldadeF1Completada = 2;
            scene = "Fase1Minigame1";
        }
        if(FinalizarFase1.dificuldade==3) {
            EsfregarTubos.velocidadeQuebra = 1500;
            LinhaScript.tempoChange = 3f;
            ExplosaoScript.quantidade = 5;
            FinalizarFase1.dificuldade = 3;
            FinalizarFase1.dificuldadeF1Completada = 3;
            scene = "Fase1Minigame1";
        }
        Pontuacao.pontos = 0;
        SceneManager.LoadScene(scene);
        ProximaFase.fase2 = 0;
    }  
}