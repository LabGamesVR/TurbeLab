using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmebaToqueNext : MonoBehaviour
{
    public Text scoreText; // Refer�ncia ao texto que exibir� a pontua��o.
    private int score = 0; // Vari�vel para armazenar a pontua��o.
    public GameObject estrela; // Anima��o Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma refer�ncia ao AudioSource.

    private bool hasBeenClicked = false; // Vari�vel para rastrear se a ameba j� foi clicada.

    // Start is called before the first frame update
    void Start()
    {
        // Certifique-se de que o Texto de Pontua��o (scoreText) esteja configurado no Inspector.
        if (scoreText == null)
        {
            Debug.LogError("O Texto de Pontua��o n�o est� configurado no Inspector!");
        }

        // Recupera o valor da pontua��o armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("Pontuacao");
        scoreText.text = "" + score;

        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        // Se o usu�rio ainda n�o clicou, n�o h� nada a fazer
        if (!hasBeenClicked)
        {
            return;
        }
        scoreText.text = "" + score;

        // Armazena o valor da pontua��o
        PlayerPrefs.SetInt("Pontuacao", score);
        PlayerPrefs.Save();
    }

    void OnMouseDown()
    {
        if (!hasBeenClicked)
        {
            // Aumente a pontua��o em 50 e atualize o texto.
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

