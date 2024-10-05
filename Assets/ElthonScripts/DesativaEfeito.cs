using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativaEfeito : MonoBehaviour
{
    public GameObject efeito;

    public void Desativar()
    {
        efeito.SetActive(false);
    }
}
