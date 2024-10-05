using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFase4Controller : MonoBehaviour
{
    public GameObject[] dificuldadeFase4;
    [SerializeField] GameObject lock1, lock2;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Diff1F4") > 0)
        {
            dificuldadeFase4[1].SetActive(true);
            lock1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff2F4") > 1)
        {
            dificuldadeFase4[2].SetActive(true);
            lock2.SetActive(false);
        }
    }
}
