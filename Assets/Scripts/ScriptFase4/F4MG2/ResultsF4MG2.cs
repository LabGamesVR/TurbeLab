using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsF4MG2 : MonoBehaviour
{
    public float delayInSeconds = 2f;
    public string sceneName;
    public Text scoreText; // componente Text para exibir a pontuação
    public int score = 0; // pontuação atual do jogador
    public GameObject fadeEnd;
    public GameObject feedback;

    void Start()
    {
        // Recupera o valor da pontuação armazenado em PlayerPrefs
        score = PlayerPrefs.GetInt("PontuacaoF4");
        scoreText.text = "" + score;
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3f);
        feedback.SetActive(false);
        fadeEnd.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName);
    }
}
