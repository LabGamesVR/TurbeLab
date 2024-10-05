using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMusica : MonoBehaviour
{
    public GameObject musica, musicaLinha;

    // Start is called before the first frame update
    void Start()
    {
        if(SomMusicaControl.musicaOnOff==0) {
            musica.GetComponent<AudioSource>().mute=false;
            musicaLinha.SetActive(false);
        } else {
            musica.GetComponent<AudioSource>().mute=false;
            musicaLinha.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SomMusicaControl.musicaOnOff==0) {
            musica.GetComponent<AudioSource>().mute=false;
        } else {
            musica.GetComponent<AudioSource>().mute=true;
        }
    }

    public void OnMouseDown() {
        if(musicaLinha.activeSelf==true) {
            SomMusicaControl.musicaOnOff=0;
            musicaLinha.SetActive(false);
        } else {
            SomMusicaControl.musicaOnOff=1;
            musicaLinha.SetActive(true);
        }
    }
}
