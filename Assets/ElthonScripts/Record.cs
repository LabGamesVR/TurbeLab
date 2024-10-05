using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public GameObject[] Stars1F1;
    public GameObject[] Stars2F1;
    public GameObject[] Stars3F1;

    public GameObject[] Stars1F2;
    public GameObject[] Stars2F2;
    public GameObject[] Stars3F2;

    public GameObject[] Stars1F3;
    public GameObject[] Stars2F3;
    public GameObject[] Stars3F3;

    public GameObject[] Stars1F4;
    public GameObject[] Stars2F4;
    public GameObject[] Stars3F4;

    public GameObject ApprovedF1;
    public GameObject ApprovedF2;
    public GameObject ApprovedF3;
    public GameObject ApprovedF4;

    public Text txtRecord;
    public Text txtRecord2;
    public Text txtRecord3;

    public Text txtRecordF2;
    public Text txtRecord2F2;
    public Text txtRecord3F2;

    public Text txtRecordF3;
    public Text txtRecord2F3;
    public Text txtRecord3F3;

    public int RecordF4;
    public Text txtRecordF4;
    public Text txtRecord2F4;
    public Text txtRecord3F4;



    void Start()
    {
        txtRecord.text = ("" + PlayerPrefs.GetFloat("Recorde Fase1"));
        txtRecord2.text = ("" + PlayerPrefs.GetFloat("Recorde FaseD2_1"));
        txtRecord3.text = ("" + PlayerPrefs.GetFloat("Recorde FaseD3_1"));

        txtRecordF2.text = ("" + PlayerPrefs.GetInt("Recorde Fase2"));
        txtRecord2F2.text = ("" + PlayerPrefs.GetInt("Recorde FaseD2_2"));
        txtRecord3F2.text = ("" + PlayerPrefs.GetInt("Recorde FaseD3_2"));

        txtRecordF3.text = ("" + PlayerPrefs.GetInt("Recorde Fase3"));
        txtRecord2F3.text = ("" + PlayerPrefs.GetInt("Recorde FaseD2_3"));
        txtRecord3F3.text = ("" + PlayerPrefs.GetInt("Recorde FaseD3_3"));

        txtRecordF4.text = ("" + PlayerPrefs.GetInt("Recorde Fase4"));
        txtRecord2F4.text = ("" + PlayerPrefs.GetInt("Recorde FaseD2_4"));
        txtRecord3F4.text = ("" + PlayerPrefs.GetInt("Recorde FaseD3_4"));
    }

    private void Update()
    {
        ActiveStars();
    }

    public void ActiveStars()
    {
        //F1D1
        if(PlayerPrefs.GetFloat("Recorde Fase1") >= 300)
        {
            Stars1F1[0].SetActive(true);
        }
        else
        {
            Stars1F1[0].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde Fase1") >= 475)
        {
            Stars1F1[1].SetActive(true);
        }
        else
        {
            Stars1F1[1].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde Fase1") >= 650)
        {
            Stars1F1[2].SetActive(true);
        }
        else
        {
            Stars1F1[2].SetActive(false);
        }

        //F1D2
        if (PlayerPrefs.GetFloat("Recorde FaseD2_1") >= 600)
        {
            Stars2F1[0].SetActive(true);
        }
        else
        {
            Stars2F1[0].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde FaseD2_1") >= 950)
        {
            Stars2F1[1].SetActive(true);
        }
        else
        {
            Stars2F1[1].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde FaseD2_1") >= 1300)
        {
            Stars2F1[2].SetActive(true);
        }
        else
        {
            Stars2F1[2].SetActive(false);
        }

        //F1D3
        if (PlayerPrefs.GetFloat("Recorde FaseD3_1") >= 900)
        {
            Stars3F1[0].SetActive(true);
        }
        else
        {
            Stars3F1[0].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde FaseD3_1") >= 1425)
        {
            Stars3F1[1].SetActive(true);
        }
        else
        {
            Stars3F1[1].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde FaseD3_1") >= 1950)
        {
            Stars3F1[2].SetActive(true);
        }
        else
        {
            Stars3F1[2].SetActive(false);
        }

        if (PlayerPrefs.GetFloat("Recorde FaseD3_1") >= 1950 && PlayerPrefs.GetFloat("Recorde FaseD2_1") >= 1300 
            && PlayerPrefs.GetFloat("Recorde Fase1") >= 650)
        {
            ApprovedF1.SetActive(true);
        }
        else
        {
            ApprovedF1.SetActive(false);
        }

        //FinalizaF1 -> F2
        //F2D1
        if (PlayerPrefs.GetInt("Recorde Fase2") >= 300)
        {
            Stars1F2[0].SetActive(true);
        }
        else
        {
            Stars1F2[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde Fase2") >= 475)
        {
            Stars1F2[1].SetActive(true);
        }
        else
        {
            Stars1F2[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde Fase2") >= 650)
        {
            Stars1F2[2].SetActive(true);
        }
        else
        {
            Stars1F2[2].SetActive(false);
        }

        //F2D2
        if (PlayerPrefs.GetInt("Recorde FaseD2_2") >= 600)
        {
            Stars2F2[0].SetActive(true);
        }
        else
        {
            Stars2F2[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD2_2") >= 950)
        {
            Stars2F2[1].SetActive(true);
        }
        else
        {
            Stars2F2[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD2_2") >= 1300)
        {
            Stars2F2[2].SetActive(true);
        }
        else
        {
            Stars2F2[2].SetActive(false);
        }

        //F2D3
        if (PlayerPrefs.GetInt("Recorde FaseD3_2") >= 900)
        {
            Stars3F2[0].SetActive(true);
        }
        else
        {
            Stars3F2[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD3_2") >= 1425)
        {
            Stars3F2[1].SetActive(true);
        }
        else
        {
            Stars3F2[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD3_2") >= 1950)
        {
            Stars3F2[2].SetActive(true);
        }
        else
        {
            Stars3F2[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD3_2") >= 1950 && PlayerPrefs.GetInt("Recorde FaseD2_2") >= 1300
            && PlayerPrefs.GetInt("Recorde Fase2") >= 650)
        {
            ApprovedF2.SetActive(true);
        }
        else
        {
            ApprovedF2.SetActive(false);
        }

        //FinalizaF2 -> F3
        //F3D1
        if (PlayerPrefs.GetInt("Recorde Fase3") >= 300)
        {
            Stars1F3[0].SetActive(true);
        }
        else
        {
            Stars1F3[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde Fase3") >= 475)
        {
            Stars1F3[1].SetActive(true);
        }
        else
        {
            Stars1F3[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde Fase3") >= 650)
        {
            Stars1F3[2].SetActive(true);
        }
        else
        {
            Stars1F3[2].SetActive(false);
        }

        //F3D2
        if (PlayerPrefs.GetInt("Recorde FaseD2_3") >= 600)
        {
            Stars2F3[0].SetActive(true);
        }
        else
        {
            Stars2F3[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD2_3") >= 950)
        {
            Stars2F3[1].SetActive(true);
        }
        else
        {
            Stars2F3[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD2_3") >= 1300)
        {
            Stars2F3[2].SetActive(true);
        }
        else
        {
            Stars2F3[2].SetActive(false);
        }

        //F3D3
        if (PlayerPrefs.GetInt("Recorde FaseD3_3") >= 900)
        {
            Stars3F3[0].SetActive(true);
        }
        else
        {
            Stars3F3[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD3_3") >= 1425)
        {
            Stars3F3[1].SetActive(true);
        }
        else
        {
            Stars3F3[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD3_3") >= 1950)
        {
            Stars3F3[2].SetActive(true);
        }
        else
        {
            Stars3F3[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD3_3") >= 1950 && PlayerPrefs.GetInt("Recorde FaseD2_3") >= 1300
            && PlayerPrefs.GetInt("Recorde Fase3") >= 650)
        {
            ApprovedF3.SetActive(true);
        }
        else
        {
            ApprovedF3.SetActive(false);
        }

        //FinalizaF3 -> F4
        //F4D1
        if (PlayerPrefs.GetInt("Recorde Fase4") >= 300)
        {
            Stars1F4[0].SetActive(true);
        }
        else
        {
            Stars1F4[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde Fase4") >= 475)
        {
            Stars1F4[1].SetActive(true);
        }
        else
        {
            Stars1F4[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde Fase4") >= 650)
        {
            Stars1F4[2].SetActive(true);
        }
        else
        {
            Stars1F4[2].SetActive(false);
        }

        //F4D2
        if (PlayerPrefs.GetInt("Recorde FaseD2_4") >= 600)
        {
            Stars2F4[0].SetActive(true);
        }
        else
        {
            Stars2F4[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD2_4") >= 950)
        {
            Stars2F4[1].SetActive(true);
        }
        else
        {
            Stars2F4[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD2_4") >= 1300)
        {
            Stars2F4[2].SetActive(true);
        }
        else
        {
            Stars2F4[2].SetActive(false);
        }

        //F4D3
        if (PlayerPrefs.GetInt("Recorde FaseD3_4") >= 900)
        {
            Stars3F4[0].SetActive(true);
        }
        else
        {
            Stars3F4[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD3_4") >= 1425)
        {
            Stars3F4[1].SetActive(true);
        }
        else
        {
            Stars3F4[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Recorde FaseD3_4") >= 1950)
        {
            Stars3F4[2].SetActive(true);
        }
        else
        {
            Stars3F4[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Recorde FaseD3_4") >= 1950 && PlayerPrefs.GetInt("Recorde FaseD2_4") >= 1300
            && PlayerPrefs.GetInt("Recorde Fase4") >= 650)
        {
            ApprovedF4.SetActive(true);
        }
        else
        {
            ApprovedF4.SetActive(false);
        }
    }
}