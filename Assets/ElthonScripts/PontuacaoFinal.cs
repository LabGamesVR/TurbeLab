using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuacaoFinal : MonoBehaviour
{
    [SerializeField]
    private int fase;

    float score;
    float scoreD2;
    float scoreD3;

    int scoreF2;
    int scoreF2D2;
    int scoreF2D3;

    int scoreF3;
    int scoreF3D2;
    int scoreF3D3;

    int scoreF4;
    int scoreF4D2;
    int scoreF4D3;

    private void Awake()
    {
        score = Pontuacao.pontos;
        scoreD2 = Pontuacao.pontos * 2;
        scoreD3 = Pontuacao.pontos * 3;

        scoreF2 = F2pontuacao.pontos;
        scoreF2D2 = F2pontuacao.pontos * 2;
        scoreF2D3 = F2pontuacao.pontos * 3;

        scoreF3 = F3Pontuacao.pontos;
        scoreF3D2 = F3Pontuacao.pontos * 2;
        scoreF3D3 = F3Pontuacao.pontos * 3;

        scoreF4 = PlayerPrefs.GetInt("PontuacaoF4");
        scoreF4D2 = (PlayerPrefs.GetInt("PontuacaoF4") * 2);
        scoreF4D3 = (PlayerPrefs.GetInt("PontuacaoF4") * 3);

        //Fase1

        if (IniciarFase1.easy == 1 && fase == 1)
        {
            if (score > (PlayerPrefs.GetFloat("Recorde Fase1")))
            {
                PlayerPrefs.SetFloat("Recorde Fase1", score);
            }
        }
        if (IniciarFase1.medium == 1 && fase == 1)
        {
            if (scoreD2 > PlayerPrefs.GetFloat("Recorde FaseD2_1"))
            {
                PlayerPrefs.SetFloat("Recorde FaseD2_1", scoreD2);
                Debug.Log(PlayerPrefs.GetFloat("Recorde FaseD2_1"));
            }
        }
        if (IniciarFase1.hard == 1 && fase == 1)
        {
            if (scoreD3 > PlayerPrefs.GetFloat("Recorde FaseD3_1"))
            {
                PlayerPrefs.SetFloat("Recorde FaseD3_1", scoreD3);
                Debug.Log(PlayerPrefs.GetFloat("Recorde FaseD3_1"));
            }
        }

        //Fase2

        if (IniciarFase2.easy == 1 && fase == 2)
        {
            if (scoreF2 > PlayerPrefs.GetInt("Recorde Fase2"))
            {
                PlayerPrefs.SetInt("Recorde Fase2", scoreF2);
            }
        }
        if (IniciarFase2.medium == 1 && fase == 2)
        {
            if (scoreF2D2 > PlayerPrefs.GetInt("Recorde FaseD2_2"))
            {
                PlayerPrefs.SetInt("Recorde FaseD2_2", scoreF2D2);
            }
        }
        if (IniciarFase2.hard == 1 && fase == 2)
        {
            if (scoreF2D3 > PlayerPrefs.GetInt("Recorde FaseD3_2"))
            {
                PlayerPrefs.SetInt("Recorde FaseD3_2", scoreF2D3);
            }
        }

        //Fase3

        if (IniciarFase3.easy == 1 && fase == 3)
        {
            if (scoreF3 > PlayerPrefs.GetInt("Recorde Fase3"))
            {
                PlayerPrefs.SetInt("Recorde Fase3", scoreF3);
            }
        }
        if (IniciarFase3.medium == 1 && fase == 3)
        {
            if (scoreF3D2 > PlayerPrefs.GetInt("Recorde FaseD2_3"))
            {
                PlayerPrefs.SetInt("Recorde FaseD2_3", scoreF3D2);
            }
        }
        if (IniciarFase3.hard == 1 && fase == 3)
        {
            if (scoreF3D3 > PlayerPrefs.GetInt("Recorde FaseD3_3"))
            {
                PlayerPrefs.SetInt("Recorde FaseD3_3", scoreF3D3);
            }
        }
        
        //Fase4

        if (IniciarFase4.dificuldade == 1 && fase == 4)
        {
            print(scoreF4);
            if (scoreF4 > PlayerPrefs.GetInt("Recorde Fase4"))
            {
                PlayerPrefs.SetInt("Recorde Fase4", scoreF4);
            }
        }
        if (IniciarFase4.dificuldade == 2 && fase == 4)
        {
            print(scoreF4D2);
            if (scoreF4D2 > PlayerPrefs.GetInt("Recorde FaseD2_4"))
            {
                PlayerPrefs.SetInt("Recorde FaseD2_4", scoreF4D2);
            }
        }
        if (IniciarFase4.dificuldade == 3 && fase == 4)
        {
            print(scoreF4D3);
            if (scoreF4D3 > PlayerPrefs.GetInt("Recorde FaseD3_4"))
            {
                PlayerPrefs.SetInt("Recorde FaseD3_4", scoreF4D3);
            }
        }
    }
}

