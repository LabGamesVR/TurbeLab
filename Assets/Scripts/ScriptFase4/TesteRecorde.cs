using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteRecorde : MonoBehaviour
{
    [SerializeField]
    private int fase;

    public int recordF4;
    public int recordF4D2;
    public int recordF4D3;

    public int scoreF4;
    public int scoreF4D2;
    public int scoreF4D3;

    private void Awake()
    {
        scoreF4 = F4Pontuacao.pontos;
        scoreF4D2 = F4Pontuacao.pontos * 2;
        scoreF4D3 = F4Pontuacao.pontos * 3;

        print(scoreF4);
        print(scoreF4D2);
        print(scoreF4D3);

        print(PlayerPrefs.GetInt("Recorde Fase4"));
        print(PlayerPrefs.GetInt("Recorde FaseD2_4"));
        print(PlayerPrefs.GetInt("Recorde FaseD3_4"));

        /*
        //Fase4

        if (IniciarFase4.dificuldade == 1 && fase == 4)
        {
            if (scoreF4 > PlayerPrefs.GetInt("Recorde Fase4"))
            {
                PlayerPrefs.SetInt("Recorde Fase4", scoreF4);
            }
        }
        if (IniciarFase4.dificuldade == 2 && fase == 4)
        {
            if (scoreF4D2 > PlayerPrefs.GetInt("Recorde FaseD2_4"))
            {
                PlayerPrefs.SetInt("Recorde FaseD2_4", scoreF4D2);
            }
        }
        if (IniciarFase4.dificuldade == 3 && fase == 4)
        {
            if (scoreF4D3 > PlayerPrefs.GetInt("Recorde FaseD3_4"))
            {
                PlayerPrefs.SetInt("Recorde FaseD3_4", scoreF4D3);
            }
        }
        */
    }
}

