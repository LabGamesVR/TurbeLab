using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigDesactive : MonoBehaviour
{
    [SerializeField] GameObject configPanel;

    public void Deactive()
    {
        configPanel.SetActive(false);
    }
}
