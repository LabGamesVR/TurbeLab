using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarF2 : MonoBehaviour
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
        if(IniciarFase2.dificuldade==1) {
            IniciarFase2.dificuldade = 1;
            scene="Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 1;
            AmebasAleatorias.velocidade = 4f;
            DificuldadeF2M3.dificuldadeF2M3 = 1;
            FinalizarFase2.dificuldadeF2Completada = 1;
        }
        if(IniciarFase2.dificuldade==2){
            IniciarFase2.dificuldade = 2;
            scene="Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 2;
            AmebasAleatorias.velocidade = 3f;
            DificuldadeF2M3.dificuldadeF2M3 = 2;
            FinalizarFase2.dificuldadeF2Completada = 2;
        }
        if(IniciarFase2.dificuldade==3) {
            IniciarFase2.dificuldade = 3;
            scene="Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 3;
            AmebasAleatorias.velocidade = 2f;
            DificuldadeF2M3.dificuldadeF2M3 = 3;
            FinalizarFase2.dificuldadeF2Completada = 3;
        }
        F2pontuacao.pontos = 0;
        SceneManager.LoadScene(scene);
    }

}
