using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public List<string> ordemDasFases = new List<string>();
    private int faseAtual = 0;

    // Gere a ordem aleat�ria das fases
    void Start()
    {
        GerarOrdemAleatoriaDasFases();
    }

    void GerarOrdemAleatoriaDasFases()
    {
        int numeroDeFases = Random.Range(6, 8); // Defina o n�mero de fases que voc� deseja

        // Comece com uma fase "T"
        ordemDasFases.Add("T");

        for (int i = 1; i < numeroDeFases - 1; i++)
        {
            ordemDasFases.Add(Random.Range(0, 2) == 0 ? "T" : "N");
        }

        // Garanta que haja pelo menos uma fase "N"
        if (!ordemDasFases.Contains("N"))
        {
            int indiceAleatorio = Random.Range(1, numeroDeFases - 1);
            ordemDasFases[indiceAleatorio] = "N";
        }

        // Termine com uma fase "T"
        ordemDasFases.Add("T");

        // Embaralhe a lista para torn�-la aleat�ria
        ordemDasFases = ordemDasFases.OrderBy(x => Random.Range(0, numeroDeFases)).ToList();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
