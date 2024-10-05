using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomMusicaControl : MonoBehaviour
{
    public static int musicaOnOff, somOnOff;
    public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {
        if(musicaOnOff==0) {
            musica.GetComponent<AudioSource>().mute=false;
        } else {
            musica.GetComponent<AudioSource>().mute=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
