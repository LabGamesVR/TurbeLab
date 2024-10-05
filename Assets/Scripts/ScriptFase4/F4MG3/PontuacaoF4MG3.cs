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
    public float toleranciaPosicao = 0.05f; // quanto mais pr�ximo de zero, mais preciso 0.1f
    public float tempoRestante = 15.0f; // tempo restante para o jogador posicionar as imagens
    public Text scoreText; // componente Text para exibir a pontua��o
    public int score = 0; // pontua��o atual do jogador
    public int foco;  // porcentagem do foco entre as imagens de Eixo X e Y com a imagem Fixa
    private bool pontuou = false; // Vari�vel para controlar se a pontua��o j� foi registrada nesta tentativa.
    public enum NivelDificuldade { Facil, Normal, Dificil };
    public NivelDificuldade nivelDificuldade = NivelDificuldade.Normal; // Defina a dificuldade desejada no Inspector.

    public GameObject estrela; // Anima��o Estrela ao acertar.
    public AudioSource audioSource; // Adicionamos uma refer�ncia ao AudioSource.
    public GameObject botoes; 
    public GameObject fadeEnd;


    // Start is called before the first frame update
    void Start()
    {
        pontuou = false;

        float randomPos = Random.Range(0.18f, 0.20f); // Valores pr�ximos do extremo direito
        float randomNeg = Random.Range(-0.18f, -0.20f); // Valores pr�ximos do extremo superior           
        float randomX = Random.Range(0f, 1f) < 0.5f ? randomPos : randomNeg; // Escolhe aleatoriamente entre randomPos e randomNeg para a posi��o no eixo X.
        float randomY = Random.Range(0f, 1f) < 0.5f ? randomPos : randomNeg; // Escolhe aleatoriamente entre randomPos e randomNeg para a posi��o no eixo Y.

        // Recupera o valor da pontua��o armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("PontuacaoF4");
        scoreText.text = "" + score;

        if (nivelDificuldade == NivelDificuldade.Dificil)
        {
            // Start Aleat�rio - NIVEL DIFICIL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, imagemEixoY.position.y, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, randomY, imagemEixoX.position.z);
            imagemEixoY.gameObject.SetActive(false);
        }
        else if (nivelDificuldade == NivelDificuldade.Facil)
        {
            // Start Aleat�rio - NIVEL FACIL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, imagemEixoY.position.y, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, imagemEixoX.position.y, imagemEixoX.position.z);
            imagemEixoY.gameObject.SetActive(false);
        }
        else
        {
            // Start Aleat�rio - NIVEL NORMAL
            imagemEixoY.position = new Vector3(imagemEixoY.position.x, randomY, imagemEixoY.position.z);
            imagemEixoX.position = new Vector3(randomX, imagemEixoX.position.y, imagemEixoX.position.z);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se o tempo acabou, contabiliza pontos com base na precis�o e finaliza a fase
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

                // Armazena o valor da pontua��o
                PlayerPrefs.SetInt("PontuacaoF4", score);
                PlayerPrefs.Save();

                pontuou = true;
                
                botoes.SetActive(false);

                F4MG3 scriptF4MG3 = FindObjectOfType<F4MG3>();

                scriptF4MG3.PararMoverEixoY();
                scriptF4MG3.PararMoverEixoX();

                // Torna a anima��o da estrela ativa
                estrela.gameObject.SetActive(true);
                audioSource.Play();

                // Chama a fun��o LoadNextScene ap�s o tempo desejado
                StartCoroutine(LoadNextScene());
            }
        }
        else
        {
            tempoRestante -= Time.deltaTime;

            // calcula a dist�ncia entre as imagens A e B em cada eixo
            float distanciaX = Mathf.Abs(imagemEixoY.position.x - imagemFixa.position.x);
            float distanciaY = Mathf.Abs(imagemEixoY.position.y - imagemFixa.position.y);

            // calcula a dist�ncia entre as imagens B e C em cada eixo
            float distanciaX2 = Mathf.Abs(imagemFixa.position.x - imagemEixoX.position.x);
            float distanciaY2 = Mathf.Abs(imagemFixa.position.y - imagemEixoX.position.y);

            // se as dist�ncias forem menores que a toler�ncia, contabiliza pontos e finaliza a fase
            if (distanciaX < toleranciaPosicao && distanciaY < toleranciaPosicao && distanciaX2 < toleranciaPosicao && distanciaY2 < toleranciaPosicao)
            {
                if (!pontuou)
                {
                    float precisao = 1.0f - ((distanciaX + distanciaY + distanciaX2 + distanciaY2) / (toleranciaPosicao * 4.0f));
                    score += Mathf.RoundToInt(300 * 1);
                    scoreText.text = score.ToString();

                    // Armazena o valor da pontua��o
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

                    // Torna a anima��o da estrela ativa
                    estrela.gameObject.SetActive(true);
                    audioSource.Play();

                    // Chama a fun��o LoadNextScene ap�s o tempo desejado
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