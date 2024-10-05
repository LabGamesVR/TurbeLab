using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public AudioSource somFaseCompletada;
    private bool continuarTimer = true;
    public string scene;
    public float tempoInicial = 0, tempoFinal;
    public GameObject pauseMenu, fade, somPipeta, somPontuando, feedBackF1M1;

    // Update is called once per frame
    void Update()
    {
        if(FinalizarFase1.dificuldade==1) {
            if(Pontuacao.pontos==250) {
                PassPhase();
            }
        }
        if(FinalizarFase1.dificuldade==2) {
            if(Pontuacao.pontos*2==500) {
                PassPhase();
            }
        }
        if (FinalizarFase1.dificuldade==3) {
            if(Pontuacao.pontos*3==750) {
                PassPhase();
            }
        }
        
        if(pauseMenu.activeSelf==false) {
            if(continuarTimer) {
                tempoInicial += (1*Time.deltaTime);
                if (tempoInicial>=tempoFinal){
                    continuarTimer = false;
                    PassPhase();
                }
            }
        }
    }


    void PassPhase() {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase() {
        somFaseCompletada.Play();
        somPipeta.SetActive(false);
        somPontuando.SetActive(false);
        if(FeedConfig.feedCount>0) {
            feedBackF1M1.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF1M1.SetActive(false);
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        } else {
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        }
    }

}
