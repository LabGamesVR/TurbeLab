using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomF1M1 : MonoBehaviour
{
    public GameObject somFaseCompletada, somPipeta, somPontuando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SomMusicaControl.somOnOff==0) {
            somPipeta.GetComponent<AudioSource>().mute=false;
            somPontuando.GetComponent<AudioSource>().mute=false;
            somFaseCompletada.GetComponent<AudioSource>().mute=false;
        } else {
            somPipeta.GetComponent<AudioSource>().mute=true;
            somPontuando.GetComponent<AudioSource>().mute=true;
            somFaseCompletada.GetComponent<AudioSource>().mute=true;
        }
    }
}
