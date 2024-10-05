using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerF4MG1 : MonoBehaviour
{
    public float delayInSeconds = 2f;
    private int dif;

    void Start()
    {
        // Obtém a dificuldade da fase de outra classe (IniciarFase4) e inicia a fase
        dif = IniciarFase4.dificuldade;

        Invoke("ChangeScene", delayInSeconds);
    }

    void ChangeScene()
    {
        if (dif == 1)
        {
            SceneManager.LoadScene("MG2_F");
        }
        else if (dif == 2)
        {
            SceneManager.LoadScene("MG2_M");
        }
        else
        {
            SceneManager.LoadScene("MG2_D");
        }
    }
}
