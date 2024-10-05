using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarFase4 : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public static int dificuldadeF4Completada;
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
        if (IniciarFase4.dificuldade == 1)
        {
            dificuldadeF4Completada = 1;
            PlayerPrefs.SetInt("Diff1F4", dificuldadeF4Completada);
        }
        if (IniciarFase4.dificuldade == 2)
        {
            dificuldadeF4Completada = 2;
            PlayerPrefs.SetInt("Diff2F4", dificuldadeF4Completada);
        }
        if (IniciarFase4.dificuldade == 3)
        {
            dificuldadeF4Completada = 3;
            PlayerPrefs.SetInt("Diff3F4", dificuldadeF4Completada);
        }
    }
}
