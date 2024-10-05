using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecionarTubosInativos : MonoBehaviour
{
    public GameObject redFade, explosao;
    public AudioSource somClicarTubo;
    //public Animator RedFade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //Pontuacao.pontos -= 25;
        somClicarTubo.Play();
        ExplosaoScript.cliques+=1;
        redFade.SetActive(false);
        redFade.SetActive(true);
        //RedFade.SetBool("Damage", true);
    }

}
