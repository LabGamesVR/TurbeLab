using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlterarImagem : MonoBehaviour
{
    public GameObject imagemAtencao;
    public GameObject imagemToque;
    public GameObject imagemNaoToque;

    public GameObject comAmeba;
    public GameObject semAmeba;

    public Text scoreText; // Refer�ncia ao texto que exibir� a pontua��o.
    public int score; // Vari�vel para armazenar a pontua��o.
    public string sceneFase;
    public string sceneFeed;
    public GameObject fadeEnd;

    public aToque aToque;
    public aNaoToque aNaoToque;

    private List<string> ordemDasFases;
    private int indiceAtual = 0;

    public float tempoDeExibicao = 2.0f; // Tempo em segundos para exibir cada imagem
    public float tempoDeIntervalo = 1.0f; // Tempo em segundos entre as imagens
    private float tempoPassado = 0.0f;
    private bool esperandoComecar = true; // Vari�vel de controle para esperar antes de come�ar

    
    void Start()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        ordemDasFases = gameManager.ordemDasFases;

        // Recupera o valor da pontua��o armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("PontuacaoF4");
        scoreText.text = "" + score;
        
        // Desative todas as imagens e objetos no in�cio
        DesativarImagensEObjetos();
        
        // Iniciar com a primeira imagem da fase atual ap�s 2 segundos
        StartCoroutine(ExibirAtencaoPorTresSegundos());
    }

    void Update()
    {
        // Verifique se estamos esperando antes de come�ar
        if (esperandoComecar)
        {
            return; // N�o fa�a nada enquanto estiver esperando
        }
        
        scoreText.text = "" + score;
        tempoPassado += Time.deltaTime;

        if (tempoPassado >= tempoDeExibicao)
        {
            indiceAtual++;
            if (indiceAtual < ordemDasFases.Count)
            {
                AtualizarImagem();
                tempoPassado = 0.0f;
            }
            else
            {
                StartCoroutine(LoadNextScene());
            }
        }
        else if (tempoPassado >= tempoDeIntervalo)
        {
            // Ap�s o tempo de exibi��o e intervalo, desative as imagens
            imagemToque.gameObject.SetActive(false);
            imagemNaoToque.gameObject.SetActive(false);
        }
    }


    void AtualizarImagem()
    {
        if (ordemDasFases[indiceAtual] == "T")
        {
            imagemToque.gameObject.SetActive(true);
            imagemNaoToque.gameObject.SetActive(false);
            comAmeba.gameObject.SetActive(true);
            semAmeba.gameObject.SetActive(false);
            aToque.hasClicked = false;
        }
        else if (ordemDasFases[indiceAtual] == "N")
        {
            imagemToque.gameObject.SetActive(false);
            imagemNaoToque.gameObject.SetActive(true);
            comAmeba.gameObject.SetActive(false);
            semAmeba.gameObject.SetActive(true);
            aNaoToque.hasClicked = false;
        }
    }

    IEnumerator ExibirAtencaoPorTresSegundos()
    {
        imagemAtencao.SetActive(true); // Ativar a imagem de "ATEN��O"

        // Aguarde 3 segundos
        yield return new WaitForSeconds(3.0f);

        imagemAtencao.SetActive(false); // Desativar a imagem de "ATEN��O"

        // Iniciar com a primeira imagem da fase atual ap�s 2 segundos
        StartCoroutine(EsperarAntesDeComecar());
    }

    IEnumerator EsperarAntesDeComecar()
    {
        yield return new WaitForSeconds(1.0f); // Espere por 2 segundos
        esperandoComecar = false; // Agora podemos come�ar a l�gica principal
        AtualizarImagem(); // Comece com a primeira imagem da fase atual
    }

    IEnumerator LoadNextScene() 
    {
        // Armazena o valor da pontua��o
        PlayerPrefs.SetInt("PontuacaoF4", score);
        PlayerPrefs.Save();
        if(FeedConfig.feedCount>0) {
            SceneManager.LoadScene(sceneFeed);
        } else {
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(sceneFase);
        }
    }


    void DesativarImagensEObjetos()
    {
        // Desative todas as imagens e objetos no in�cio
        imagemToque.gameObject.SetActive(false);
        imagemNaoToque.gameObject.SetActive(false);
        comAmeba.gameObject.SetActive(false);
        semAmeba.gameObject.SetActive(false);
    }
}

