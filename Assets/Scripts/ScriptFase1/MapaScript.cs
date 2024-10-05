using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaScript : MonoBehaviour
{
    public GameObject fase1Check3, fase2Check3, fase3Check3, fase4Check3;
    public GameObject fase2Lock, fase3Lock, fase4Lock, fase5Lock;
    //public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fase1Check3.activeSelf==true) {
            fase2Lock.SetActive(false);
        }
        if(fase2Check3.activeSelf==true) {
            fase3Lock.SetActive(false);
        }
        if(fase3Check3.activeSelf==true) {
            fase4Lock.SetActive(false);
        }
        if(fase4Check3.activeSelf==true) {
            fase5Lock.SetActive(false);
        }
    }
}
