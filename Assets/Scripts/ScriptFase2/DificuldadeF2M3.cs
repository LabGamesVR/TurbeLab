using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificuldadeF2M3 : MonoBehaviour
{
    public static int dificuldadeF2M3;
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        if(dificuldadeF2M3 == 1) {
            enemy[0].SetActive(false);
            enemy[1].SetActive(true);
            enemy[2].SetActive(false);
            enemy[3].SetActive(true);
            enemy[4].SetActive(true);
            enemy[5].SetActive(false);
            enemy[6].SetActive(false);
        }

        if(dificuldadeF2M3 == 2) {
            enemy[0].SetActive(false);
            enemy[1].SetActive(true);
            enemy[2].SetActive(true);
            enemy[3].SetActive(true);
            enemy[4].SetActive(false);
            enemy[5].SetActive(true);
            enemy[6].SetActive(false);
        }

        if(dificuldadeF2M3 == 3) {
            enemy[0].SetActive(true);
            enemy[1].SetActive(true);
            enemy[2].SetActive(true);
            enemy[3].SetActive(true);
            enemy[4].SetActive(true);
            enemy[5].SetActive(true);
            enemy[6].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
