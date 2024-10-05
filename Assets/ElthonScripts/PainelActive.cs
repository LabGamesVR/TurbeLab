using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelActive : MonoBehaviour
{
    public GameObject painel;

    public void Ativo()
    {
        DificuldadeF2M3.dificuldadeF2M3 = 1;
        painel.SetActive(true);
    }
}
