using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PontuacaoF4MG3 : MonoBehaviour
{
    public Transform imagemFixa;
    public Transform imagemEixoY;
    public Transform imagemEixoX;
    public string sceneFase;
    public string sceneFeed;
    public float toleranciaPosicao = 0.05f; // quanto mais próximo de zero, mais preciso 0.1f
    public float tempoRestante = 15.0f; // tempo restante para o jogador posicionar as imagens
    public Text scoreText; // componente Text para exibir a pontuação
    public int score = 0; // pontuação atual do jogador
    public int foco;  // porcentagem do foco entre as imagens de Eixo X e Y com a imagem Fixa
    private bool pontuou = false; // Variável para controlar se a pontuação já foi registrada nesta tentativa.
    public enum NivelDificuldade { Facil, Normal, Dificil };
    public NivelDificuldade nivelDificuldade = NivelDificuldade.Normal; // Defina a dificuldade desejada no Inspector.

    public GameObject estrela; // Animação Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma referência ao AudioSource.
    public GameObject botoes; 
    public GameObject fadeEnd;


    // Start is called before the first frame update
    void Start()
    {
        pontuou = false;

        float randomPos = Random.Range(0.18f, 0.20f); // Valores próximos do extremo direito
        float randomNeg = Random.Range(-0.18f, -0.20f); // Valores próximos do extremo superior           
        float randomX = Random.Range(0f, 1f) < 0.5f ? randomPos : randomNeg; // Escolhe aleatoriamente entre randomPos e randomNeg para a posição no eixo X.
        float randomY = Random.Range(0f, 1f) < 0.5f ? randomPos : randomNeg; // Escolhe aleatoriamente entre randomPos e randomNeg para a posição no eixo Y.

        // Recupera o valor da pontuação armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("PontuacaoF4");
        scoreText.text = "" + score;

        if (nivelDificuldade == NivelDificuldade.Dificil)
        {
            // Start Aleatório - NIVEL DIFICIL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, imagemEixoY.position.y, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, randomY, imagemEixoX.position.z);
            imagemEixoY.gameObject.SetActive(false);
        }
        else if (nivelDificuldade == NivelDificuldade.Facil)
        {
            // Start Aleatório - NIVEL FACIL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, imagemEixoY.position.y, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, imagemEixoX.position.y, imagemEixoX.position.z);
            imagemEixoY.gameObject.SetActive(false);
        }
        else
        {
            // Start Aleatório - NIVEL NORMAL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, randomY, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, imagemEixoX.position.y, imagemEixoX.position.z);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se o tempo acabou, contabiliza pontos com base na precisão e finaliza a fase
        if (tempoRestante <= 0)
        {
            if (!pontuou)    
            {
                float distanciaX = Mathf.Abs(imagemEixoY.position.x - imagemFixa.position.x);
                float distanciaY = Mathf.Abs(imagemEixoY.position.y - imagemFixa.position.y);
                float distanciaX2 = Mathf.Abs(imagemFixa.position.x - imagemEixoX.position.x);
                float distanciaY2 = Mathf.Abs(imagemFixa.position.y - imagemEixoX.position.y);

                float precisao = Mathf.Max(0, 1 - (distanciaX + distanciaY + distanciaX2 + distanciaY2) / (toleranciaPosicao * 4));
                score += Mathf.RoundToInt(300 * precisao);
                scoreText.text = score.ToString();
                botoes.SetActive(false);

                // Armazena o valor da pontuação
                PlayerPrefs.SetInt("PontuacaoF4", score);
                PlayerPrefs.Save();

                pontuou = true;
                
                botoes.SetActive(false);

                F4MG3 scriptF4MG3 = FindObjectOfType<F4MG3>();

                scriptF4MG3.PararMoverEixoY();
                scriptF4MG3.PararMoverEixoX();

                // Torna a animação da estrela ativa
                estrela.gameObject.SetActive(true);
                audioSource.Play();

                // Chama a função LoadNextScene após o tempo desejado
                StartCoroutine(LoadNextScene());
            }
        }
        else
        {
            tempoRestante -= Time.deltaTime;

            // calcula a distância entre as imagens A e B em cada eixo
            float distanciaX = Mathf.Abs(imagemEixoY.position.x - imagemFixa.position.x);
            float distanciaY = Mathf.Abs(imagemEixoY.position.y - imagemFixa.position.y);

            // calcula a distância entre as imagens B e C em cada eixo
            float distanciaX2 = Mathf.Abs(imagemFixa.position.x - imagemEixoX.position.x);
            float distanciaY2 = Mathf.Abs(imagemFixa.position.y - imagemEixoX.position.y);

            // se as distâncias forem menores que a tolerância, contabiliza pontos e finaliza a fase
            if (distanciaX < toleranciaPosicao && distanciaY < toleranciaPosicao && distanciaX2 < toleranciaPosicao && distanciaY2 < toleranciaPosicao)
            {
                if (!pontuou)
                {
                    float precisao = 1.0f - ((distanciaX + distanciaY + distanciaX2 + distanciaY2) / (toleranciaPosicao * 4.0f));
                    score += Mathf.RoundToInt(300 * 1);
                    scoreText.text = score.ToString();

                    // Armazena o valor da pontuação
                    PlayerPrefs.SetInt("PontuacaoF4", score);
                    PlayerPrefs.Save();

                    pontuou = true;
                    botoes.SetActive(false);

                    F4MG3[] scriptsF4MG3 = FindObjectsOfType<F4MG3>();

                    foreach (F4MG3 scriptF4MG3 in scriptsF4MG3)
                    {
                        scriptF4MG3.PararMoverEixoY();
                        scriptF4MG3.PararMoverEixoX();
                    }

                    // Torna a animação da estrela ativa
                    estrela.gameObject.SetActive(true);
                    audioSource.Play();

                    // Chama a função LoadNextScene após o tempo desejado
                    StartCoroutine(LoadNextScene());
                }
            }
        }
    }

    IEnumerator LoadNextScene()
    {
        if(FeedConfig.feedCount>0) {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(sceneFeed);
        } else {
            yield return new WaitForSeconds(2f);
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(sceneFase);
        }
    }
}