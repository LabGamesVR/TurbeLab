using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarFase2 : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public static int dificuldadeF2Completada;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
        if (IniciarFase2.dificuldade == 1)
        {
            dificuldadeF2Completada = 1;
            PlayerPrefs.SetInt("Diff1F2", dificuldadeF2Completada);
        }
        if (IniciarFase2.dificuldade == 2)
        {
            dificuldadeF2Completada = 2;
            PlayerPrefs.SetInt("Diff2F2", dificuldadeF2Completada);
        }
        if (IniciarFase2.dificuldade == 3)
        {
            dificuldadeF2Completada = 3;
            PlayerPrefs.SetInt("Diff3F2", dificuldadeF2Completada);
        }
    }
}
