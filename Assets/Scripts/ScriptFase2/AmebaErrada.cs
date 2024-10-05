using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmebaErrada : MonoBehaviour
{
    public GameObject amebaErrada, touchBlock;
    public AudioSource somClicar;
    public Text frase;
    public Animator fadeRed;


    void OnMouseDown() {
        AmebasAleatorias.errou = true;
        //F2pontuacao.pontos -= 100;
        //AmebasAleatorias.isDone = true;
        AmebasAleatorias.dedoX = 1;
        somClicar.Play();
        //frase.text = "Errou!";
        fadeRed.SetBool("Damage", true);
        touchBlock.SetActive(true);
    }
}
