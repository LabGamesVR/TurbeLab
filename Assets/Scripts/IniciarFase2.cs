using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IniciarFase2 : MonoBehaviour
{
    public GameObject facil, medio, dificil;
    public static int easy, medium, hard;
    public string scene;
    public static int dificuldade;
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
        F2pontuacao.pontos = 0;
        if (facil.activeSelf == true)
        {
            dificuldade = 1;
            scene = "Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 1;
            AmebasAleatorias.dificuldadeF2M2 = 1;
            DificuldadeF2M3.dificuldadeF2M3 = 1;
            easy = 1;
            medium = 0;
            hard = 0;
        }
        if (medio.activeSelf == true)
        {
            dificuldade = 2;
            scene = "Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 2;
            AmebasAleatorias.dificuldadeF2M2 = 2;
            DificuldadeF2M3.dificuldadeF2M3 = 2;
            easy = 0;
            medium = 1;
            hard = 0;
        }
        if (dificil.activeSelf == true)
        {
            dificuldade = 3;
            scene = "Fase2M1";
            DificuldadeF2M1.dificuldadeF2M1 = 3;
            AmebasAleatorias.dificuldadeF2M2 = 3;
            DificuldadeF2M3.dificuldadeF2M3 = 3;
            easy = 0;
            medium = 0;
            hard = 1;
        }
        if (facil.activeSelf == true || medio.activeSelf == true || dificil.activeSelf == true)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
