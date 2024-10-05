using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigActive : MonoBehaviour
{
    [SerializeField] GameObject configPanel;

    public void Active()
    {
        configPanel.SetActive(true);
    }
}
