using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class aToque : MonoBehaviour
{
    public GameObject estrela; // Animação Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma referência ao AudioSource.

    public bool hasClicked = false; // Variável para rastrear se a ameba já foi clicada.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Se o usuário ainda não clicou, não há nada a fazer
        if (!hasClicked)
        {
            return;
        }
    }

    void OnMouseDown()
    {
        AlterarImagem scriptAlterarImagem = FindObjectOfType<AlterarImagem>();

        if (!hasClicked && scriptAlterarImagem != null)
        {
            // Aumente a pontuação em 50 e atualize o texto.
            scriptAlterarImagem.score += 50;

            // Marque a ameba como clicada.
            hasClicked = true;

            // Torna a imagem ativa
            estrela.gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}
