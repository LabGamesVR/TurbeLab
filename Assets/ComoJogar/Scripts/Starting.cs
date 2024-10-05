using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
    public string cena;

    public void NewScene()
    {
        DificuldadeF2M3.dificuldadeF2M3 = 1;
        DificuldadeF2M1.dificuldadeF2M1 = 1;
        SceneManager.LoadScene(cena);
    }
}
