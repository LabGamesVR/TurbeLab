using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IniciarFase4 : MonoBehaviour
{
    public GameObject facil, medio, dificil;
    public static int dificuldade, numArtefatos;
    private string scene;
    public static int easy, medium, hard;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        F4Pontuacao.pontos = 0;
        if (facil.activeSelf == true)
        {
            dificuldade = 1;
            SequenceValidation.dificuldade = 1;
            easy = 1;
            medium = 0;
            hard = 0;
            scene = "Fase4M1_F";
            numArtefatos = 4;
        }
        if (medio.activeSelf == true)
        {
            dificuldade = 2;
            SequenceValidation.dificuldade = 2;
            easy = 0;
            medium = 1;
            hard = 0;
            scene = "Fase4M1_F";
            numArtefatos = 7;
        }
        if (dificil.activeSelf == true)
        {
            dificuldade = 3;
            SequenceValidation.dificuldade = 3;
            easy = 0;
            medium = 0;
            hard = 1;
            scene = "Fase4M1_F";
            numArtefatos = 9;
        }
        if (facil.activeSelf == true || medio.activeSelf == true || dificil.activeSelf == true)
        {
            SceneManager.LoadScene(scene);
        }
    }
}

