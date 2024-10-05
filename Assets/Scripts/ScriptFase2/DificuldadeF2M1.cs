using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificuldadeF2M1 : MonoBehaviour
{
    public GameObject[] niveis;
    public static int dificuldadeF2M1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(dificuldadeF2M1 == 1) {
            niveis[0].SetActive(true);
            niveis[1].SetActive(false);
            niveis[2].SetActive(false);
        }

        if(dificuldadeF2M1 == 2) {
            niveis[0].SetActive(false);
            niveis[1].SetActive(true);
            niveis[2].SetActive(false);
        }

        if(dificuldadeF2M1 == 3) {
            niveis[0].SetActive(false);
            niveis[1].SetActive(false);
            niveis[2].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
