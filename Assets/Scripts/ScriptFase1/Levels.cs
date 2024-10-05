using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject informacao;
    public GameObject[] cadeadoFases, FasesChecks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Fase1
        if (FasesChecks[0].activeSelf == true)
        {
            informacao.SetActive(true);
        }
        else
        {
            informacao.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff1") > 0)
        {
            cadeadoFases[1].SetActive(false);
            FasesChecks[0].SetActive(true);
        }
        else
        {
            cadeadoFases[1].SetActive(true);
            FasesChecks[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff2") > 1)
        {
            FasesChecks[1].SetActive(true);
        }
        else
        {
            FasesChecks[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff3") > 2)
        {
            FasesChecks[2].SetActive(true);
        }
        else
        {
            FasesChecks[2].SetActive(false);
        }

        //Fase2
        if (PlayerPrefs.GetInt("Diff1F2") > 0)
        {
            cadeadoFases[2].SetActive(false);
            FasesChecks[3].SetActive(true);
        }
        else
        {
            cadeadoFases[2].SetActive(true);
            FasesChecks[3].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff2F2") > 1)
        {
            FasesChecks[4].SetActive(true);
        }
        else
        {
            FasesChecks[4].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff3F2") > 2)
        {
            FasesChecks[5].SetActive(true);
        }
        else
        {
            FasesChecks[5].SetActive(false);
        }

        //Fase3
        if (PlayerPrefs.GetInt("Diff1F3") > 0)
        {
            cadeadoFases[3].SetActive(false);
            FasesChecks[6].SetActive(true);
        }
        else
        {
            cadeadoFases[3].SetActive(true);
            FasesChecks[6].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff2F3") > 1)
        {
            FasesChecks[7].SetActive(true);
        }
        else
        {
            FasesChecks[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff3F3") > 2)
        {
            FasesChecks[8].SetActive(true);
        }
        else
        {
            FasesChecks[8].SetActive(false);
        }

        //Fase4
        if (PlayerPrefs.GetInt("Diff1F4") > 0)
        {
            FasesChecks[9].SetActive(true);
        }
        else
        {
            FasesChecks[9].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Diff2F4") > 1)
        {
            FasesChecks[10].SetActive(true);
        }
        else
        {
            FasesChecks[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diff3F4") > 2)
        {
            FasesChecks[11].SetActive(true);
        }
        else
        {
            FasesChecks[11].SetActive(false);
        }
    }
}