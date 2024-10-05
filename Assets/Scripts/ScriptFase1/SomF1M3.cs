using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomF1M3 : MonoBehaviour
{
    public GameObject somFaseCompletada, somExplosao, somClicarTubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SomMusicaControl.somOnOff==0) {
            somExplosao.GetComponent<AudioSource>().mute=false;
            somClicarTubo.GetComponent<AudioSource>().mute=false;
            somFaseCompletada.GetComponent<AudioSource>().mute=false;
        } else {
            somExplosao.GetComponent<AudioSource>().mute=true;
            somClicarTubo.GetComponent<AudioSource>().mute=true;
            somFaseCompletada.GetComponent<AudioSource>().mute=true;
        }
    }
}
