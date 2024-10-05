using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFase2Controller : MonoBehaviour
{
    public GameObject[] dificuldadeFase2;
    [SerializeField] GameObject lock1, lock2;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Diff1F2") > 0)
        {
            dificuldadeFase2[1].SetActive(true);
            lock1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff2F2") > 1)
        {
            dificuldadeFase2[2].SetActive(true);
            lock2.SetActive(false);
        }
    }
}
