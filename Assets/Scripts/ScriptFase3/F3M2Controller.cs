using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F3M2Controller : MonoBehaviour
{
    public GameObject diff1Line, diff2Line, diff3Line;
    public GameObject diff1Col, diff2Col, diff3Col;
    public GameObject fade;

    public GameObject stars, redfade, feedBackF3M2;

    public AudioSource somErrado;
    public AudioSource somCompleto;
    void Start()
    {
        if(IniciarFase3.easy == 1)
        {
            diff1Line.SetActive(true);
            diff1Col.SetActive(true);
        }
        else if (IniciarFase3.medium == 1)
        {
            diff2Line.SetActive(true);
            diff2Col.SetActive(true);
        }
        else if (IniciarFase3.hard == 1)
        {
            diff3Line.SetActive(true);
            diff3Col.SetActive(true);
        }
    }

    public void Stars()
    {
        stars.SetActive(true);
        redfade.SetActive(false);
    }

    IEnumerator Errado()
    {
        somErrado.Play();
        yield return new WaitForSeconds(2.5f);
    }

    public void RedFade()
    {
        redfade.SetActive(true);
        StartCoroutine(Errado());
        stars.SetActive(false);
    }
    public void NextScene()
    {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase()
    {
        somCompleto.Play();
        if (FeedConfig.feedCount > 0)
        {
            feedBackF3M2.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF3M2.SetActive(false);
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Fase3M3");
        }
        else
        {
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Fase3M3");
        }
    }
}
