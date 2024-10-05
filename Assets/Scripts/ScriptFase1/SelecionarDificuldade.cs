using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecionarDificuldade : MonoBehaviour
{
    public GameObject dificuldade, dificuldade2, dificuldade3;


    public void OnMouseDown() {
        dificuldade.SetActive(true);
        dificuldade2.SetActive(false);
        dificuldade3.SetActive(false);
    }
}
