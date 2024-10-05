using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmebaToqueNext : MonoBehaviour
{
    public Text scoreText; // Referência ao texto que exibirá a pontuação.
    private int score = 0; // Variável para armazenar a pontuação.
    public GameObject estrela; // Animação Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma referência ao AudioSource.

    private bool hasBeenClicked = false; // Variável para rastrear se a ameba já foi clicada.

    // Start is called before the first frame update
    void Start()
    {
        // Certifique-se de que o Texto de Pontuação (scoreText) esteja configurado no Inspector.
        if (scoreText == null)
        {
            Debug.LogError("O Texto de Pontuação não está configurado no Inspector!");
        }

        // Recupera o valor da pontuação armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("Pontuacao");
        scoreText.text = "" + score;

        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        // Se o usuário ainda não clicou, não há nada a fazer
        if (!hasBeenClicked)
        {
            return;
        }
        scoreText.text = "" + score;

        // Armazena o valor da pontuação
        PlayerPrefs.SetInt("Pontuacao", score);
        PlayerPrefs.Save();
    }

    void OnMouseDown()
    {
        if (!hasBeenClicked)
        {
            // Aumente a pontuação em 50 e atualize o texto.
            score += 50;
            scoreText.text = "" + score;

            // Marque a ameba como clicada.
            hasBeenClicked = true;

            // Torna a imagem ativa
            estrela.gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}

