using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomF4MG1 : MonoBehaviour
{
    public GameObject somFaseCompletada, somAcertou, somErrou, somCurtoCircuito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SomMusicaControl.somOnOff == 0)
        {
            somFaseCompletada.GetComponent<AudioSource>().mute = false;
            somAcertou.GetComponent<AudioSource>().mute = false;
            somErrou.GetComponent<AudioSource>().mute = false;
            somCurtoCircuito.GetComponent<AudioSource>().mute = false;
        }
        else
        {
            somFaseCompletada.GetComponent<AudioSource>().mute = true;
            somAcertou.GetComponent<AudioSource>().mute = true;
            somErrou.GetComponent<AudioSource>().mute = true;
            somCurtoCircuito.GetComponent<AudioSource>().mute = true;
        }
    }
}
