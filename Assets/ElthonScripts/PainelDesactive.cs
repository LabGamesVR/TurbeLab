using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelDesactive : MonoBehaviour
{
    public GameObject painel;

    public void Desativo()
    {
        painel.SetActive(false);
    }
}
