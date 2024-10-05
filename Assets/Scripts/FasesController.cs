using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasesController : MonoBehaviour
{
    public GameObject[] fases;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ProximaFase.fase2==1) {
            fases[1].SetActive(true);
        }
    }
}
