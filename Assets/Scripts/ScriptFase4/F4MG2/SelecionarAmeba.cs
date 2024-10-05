using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;



public class SelecionarAmeba : MonoBehaviour
{
    public GameObject star;
    public AudioSource somClicarTubo;
    public int score;
    public Text scoreText;
    public bool check = true;
    private bool hasClicked = false;



    
    void Start()
    {
        // Recupera o valor da pontuação armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("Pontuacao");
        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        // Se o usuário ainda não clicou, não há nada a fazer
        if (!hasClicked)
        {
            return;
        }
        scoreText.text = "" + score;
    }

    void OnMouseDown() {
        Pontuacao.pontos += 50;
        star.SetActive(false);
        star.SetActive(true);
        somClicarTubo.Play();
    }
}
