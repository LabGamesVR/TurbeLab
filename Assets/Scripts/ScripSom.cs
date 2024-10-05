using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripSom : MonoBehaviour
{
    public GameObject /*som2,*/ somLinha;

    void Start()
    {
        if(SomMusicaControl.somOnOff==0) {
            somLinha.SetActive(false);
            //som2.SetActive(true);
        } else {
            somLinha.SetActive(true);
            //som2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown() {
        if(somLinha.activeSelf==true) {
            SomMusicaControl.somOnOff=0;
            //som2.SetActive(true);
            somLinha.SetActive(false);
        } else {
            SomMusicaControl.somOnOff=1;
            //som2.SetActive(false);
            somLinha.SetActive(true);
        }
    }
}
