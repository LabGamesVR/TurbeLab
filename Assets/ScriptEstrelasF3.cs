using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEstrelasF3 : MonoBehaviour
{
    public GameObject[] estrela;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IniciarFase3.dificuldade==1) {
            if(F3Pontuacao.pontos>=300) {
                estrela[0].SetActive(true);
            }
            if(F3Pontuacao.pontos>=475) {
                estrela[1].SetActive(true);
            }
            if(F3Pontuacao.pontos>=650) {
                estrela[2].SetActive(true);
            }
        }

        if(IniciarFase3.dificuldade==2) {
            if(F3Pontuacao.pontos>=600) {
                estrela[0].SetActive(true);
            }
            if(F3Pontuacao.pontos*2>=950) {
                estrela[1].SetActive(true);
            }
            if(F3Pontuacao.pontos*2>=1300) {
                estrela[2].SetActive(true);
            }
        }

        if(IniciarFase3.dificuldade==3) {
            if(F3Pontuacao.pontos*3>=900) {
                estrela[0].SetActive(true);
            }
            if(F3Pontuacao.pontos*3>=1425) {
                estrela[1].SetActive(true);
            }
            if(F3Pontuacao.pontos*3>=1950) {
                estrela[2].SetActive(true);
            }
        }
    }
}
