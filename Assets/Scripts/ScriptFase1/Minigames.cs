using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigames : MonoBehaviour
{
    public GameObject m1, m2, m3, timer1, timer2;
    public GameObject tubo1Ativo, tubo2Ativo, tubo3Ativo, tubo4Ativo;
    public GameObject tubo1Inativo, tubo2Inativo, tubo3Inativo, tubo4Inativo;
    public static int i=0;
    public float tempoInicial = 0;
    private bool continuarTimer = false;
    public float tempoInicial2 = 0;
    private bool continuarTimer2 = true;

    public int x = i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer1.GetComponent<Timer>().tempoInicial>=15) {
            m1.SetActive(false);
            m2.SetActive(true);
        }
        if(i==4&&m2.activeSelf==true) {
            continuarTimer=true;
            if(continuarTimer) {
                tempoInicial += (1*Time.deltaTime);
                if(tempoInicial>=2) {
                    m3.SetActive(true);
                    m2.SetActive(false);
                    continuarTimer=false;
                }
            }
        }
        if(tubo1Inativo.activeSelf==true && tubo2Inativo.activeSelf==true && tubo3Inativo.activeSelf==true && tubo4Inativo.activeSelf==true && tubo1Ativo.activeSelf==false && tubo2Ativo.activeSelf==false && tubo3Ativo.activeSelf==false && tubo4Ativo.activeSelf==false) {
            if(continuarTimer2) {
                tempoInicial2 += (1*Time.deltaTime);
                if(tempoInicial2>=2) {
                    continuarTimer2=false;
                    m3.SetActive(false);
                }
            }
        }
    }
}