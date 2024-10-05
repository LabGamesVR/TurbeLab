using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFase1Controller : MonoBehaviour
{
    public GameObject[] dificuldadeFase1;
    [SerializeField] GameObject lock1, lock2;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Diff1") > 0)
        {
            dificuldadeFase1[1].SetActive(true);
            lock1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff2") > 1)
        {
            dificuldadeFase1[2].SetActive(true);
            lock2.SetActive(false);
        }
    }
}
