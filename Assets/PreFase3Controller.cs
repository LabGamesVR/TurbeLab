using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFase3Controller : MonoBehaviour
{
    public GameObject[] dificuldadeFase3;
    [SerializeField] GameObject lock1, lock2;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Diff1F3") > 0)
        {
            dificuldadeFase3[1].SetActive(true);
            lock1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff2F3") > 1)
        {
            dificuldadeFase3[2].SetActive(true);
            lock2.SetActive(false);
        }
    }
}