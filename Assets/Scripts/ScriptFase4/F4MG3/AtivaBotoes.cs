using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaBotoes : MonoBehaviour
{
    public GameObject objetoParaAtivar; // Arraste o GameObject que você deseja ativar aqui.
    public float tempoDeEspera = 1.0f; // Tempo em segundos antes de ativar o objeto.

    private float tempoAtual = 0f;
    private bool ativado = false;

    private void Update()
    {
        if (!ativado)
        {
            tempoAtual += Time.deltaTime;

            if (tempoAtual >= tempoDeEspera)
            {
                AtivarObjeto();
            }
        }
    }

    private void AtivarObjeto()
    {
        if (objetoParaAtivar != null)
        {
            objetoParaAtivar.SetActive(true);
            ativado = true;
        }
        else
        {
            Debug.LogWarning("O GameObject para ativar não foi atribuído.");
        }
    }
}

