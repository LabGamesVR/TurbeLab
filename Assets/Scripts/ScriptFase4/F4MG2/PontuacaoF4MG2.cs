using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;



public class PontuacaoF4MG2 : MonoBehaviour
{
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // Zera a pontuação ao começar o jogo
        score = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        // Armazena o valor da pontuação
        PlayerPrefs.SetInt("Pontuacao", score);
        PlayerPrefs.Save();
    }
}
