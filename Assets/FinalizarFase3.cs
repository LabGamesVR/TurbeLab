using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarFase3 : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public static int dificuldadeF3Completada;
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
        if (IniciarFase3.dificuldade == 1)
        {
            dificuldadeF3Completada = 1;
            PlayerPrefs.SetInt("Diff1F3", dificuldadeF3Completada);
        }
        if (IniciarFase3.dificuldade == 2)
        {
            dificuldadeF3Completada = 2;
            PlayerPrefs.SetInt("Diff2F3", dificuldadeF3Completada);
        }
        if (IniciarFase3.dificuldade == 3)
        {
            dificuldadeF3Completada = 3;
            PlayerPrefs.SetInt("Diff3F3", dificuldadeF3Completada);
        }
    }
}
