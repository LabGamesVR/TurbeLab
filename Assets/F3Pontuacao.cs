using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F3Pontuacao : MonoBehaviour
{
    public Text pontuacao;
    public static int pontos;
    public int pontosMedio, pontosDificil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = pontos.ToString();
        pontosMedio = pontos*2;
        pontosDificil = pontos*3;
        if(IniciarFase3.dificuldade==1) {
            pontuacao.text = pontos.ToString();
        }
        if(IniciarFase3.dificuldade==2) {
            pontuacao.text = pontosMedio.ToString();
        }
        if(IniciarFase3.dificuldade==3) {
            pontuacao.text = pontosDificil.ToString();
        }
    }
}
