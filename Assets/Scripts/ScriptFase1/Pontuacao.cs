using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{   
    public Text pontuacao;
    public static float pontos;
    public float pontosMedio, pontosDificil;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        pontuacao.text = pontos.ToString();
        pontosMedio = pontos*2;
        pontosDificil = pontos*3;
        if(FinalizarFase1.dificuldade==1) {
            pontuacao.text = Math.Ceiling(pontos).ToString();
        }
        if(FinalizarFase1.dificuldade==2) {
            pontuacao.text = Math.Ceiling(pontosMedio).ToString();
        }
        if(FinalizarFase1.dificuldade==3) {
            pontuacao.text = Math.Ceiling(pontosDificil).ToString();
        }
    }
}
