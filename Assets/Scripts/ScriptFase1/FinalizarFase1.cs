using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalizarFase1 : MonoBehaviour
{
    public string scene;
    public static int dificuldade;
    public static int dificuldadeF1Completada;
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
        SceneManager.LoadScene(scene);
        if (dificuldade == 1)
        {
            dificuldadeF1Completada = 1;
            PlayerPrefs.SetInt("Diff1", dificuldadeF1Completada);
        }
        if (dificuldade == 2)
        {
            dificuldadeF1Completada = 2;
            PlayerPrefs.SetInt("Diff2", dificuldadeF1Completada);
        }
        if (dificuldade == 3)
        {
            dificuldadeF1Completada = 3;
            PlayerPrefs.SetInt("Diff3", dificuldadeF1Completada);
        }
    }

}
