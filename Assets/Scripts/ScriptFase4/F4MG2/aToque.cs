using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class aToque : MonoBehaviour
{
    public GameObject estrela; // Anima��o Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma refer�ncia ao AudioSource.

    public bool hasClicked = false; // Vari�vel para rastrear se a ameba j� foi clicada.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Se o usu�rio ainda n�o clicou, n�o h� nada a fazer
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
            // Aumente a pontua��o em 50 e atualize o texto.
            scriptAlterarImagem.score += 50;

            // Marque a ameba como clicada.
            hasClicked = true;

            // Torna a imagem ativa
            estrela.gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}
