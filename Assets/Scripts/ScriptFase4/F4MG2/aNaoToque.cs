using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class aNaoToque : MonoBehaviour
{
    public GameObject redFade; // Anima��o redFade ao errar.
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
            // Reduz a pontua��o em 25 e atualize o texto.
            scriptAlterarImagem.score -= 25;

            // Marque a ameba como clicada.
            hasClicked = true;

            // Torna a imagem ativa
            redFade.gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}
