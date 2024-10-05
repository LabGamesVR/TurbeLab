using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmebaCorreta : MonoBehaviour
{
    public GameObject  amebaCorreta, touchBlock;
    public AudioSource somClicar;
    public Text frase;
    public GameObject estrelas1;

    //public AmebasAleatorias amebasAleatorias;

    void OnMouseDown() {
        amebaCorreta.SetActive(false);
        somClicar.Play();
        AmebasAleatorias.isDone = true;
        AmebasAleatorias.dedoX = 1;
        //frase.text = "Acertou!";
        estrelas1.SetActive(true);
        touchBlock.SetActive(true);
    }
}
