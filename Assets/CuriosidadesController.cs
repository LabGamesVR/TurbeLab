using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuriosidadesController : MonoBehaviour
{
    public GameObject[] panelFase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() {
        panelFase[0].SetActive(true);
        panelFase[1].SetActive(false);
        panelFase[2].SetActive(false);
        panelFase[3].SetActive(false);
    }
}
