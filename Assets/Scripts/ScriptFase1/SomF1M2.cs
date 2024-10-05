using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomF1M2 : MonoBehaviour
{
    public GameObject somFaseCompletada, somQuebrou, somLimpou, somVidroBatendo, somEsfregando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SomMusicaControl.somOnOff==0) {
            somFaseCompletada.GetComponent<AudioSource>().mute=false;
            somQuebrou.GetComponent<AudioSource>().mute=false;
            somLimpou.GetComponent<AudioSource>().mute=false;
            somVidroBatendo.GetComponent<AudioSource>().mute=false;
            somEsfregando.GetComponent<AudioSource>().mute=false;
        } else {
            somFaseCompletada.GetComponent<AudioSource>().mute=true;
            somQuebrou.GetComponent<AudioSource>().mute=true;
            somLimpou.GetComponent<AudioSource>().mute=true;
            somVidroBatendo.GetComponent<AudioSource>().mute=true;
            somEsfregando.GetComponent<AudioSource>().mute=true;
        }
    }
}
