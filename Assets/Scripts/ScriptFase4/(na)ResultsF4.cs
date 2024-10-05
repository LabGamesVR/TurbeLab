using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsF4 : MonoBehaviour
{
    public string nextScene;
    public float tempoRestante = 5.0f; // tempo restante para o jogador posicionar as imagens
    public Text scoreText; // componente Text para exibir a pontuação
    public int score; // pontuação atual do jogador

    // Start is called before the first frame update
    void Start()
    {

        // Recupera o valor da pontuação armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("Pontuacao");
        scoreText.text = "" + score;

    }

    // Update is called once per frame
    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else
        {
            // Armazena o valor da pontuação
            PlayerPrefs.SetInt("Pontuacao", score);
            PlayerPrefs.Save();

            SceneManager.LoadScene(nextScene);
        }
    }
}
