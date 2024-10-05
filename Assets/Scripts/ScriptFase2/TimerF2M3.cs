using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerF2M3 : MonoBehaviour
{
    private bool continuarTimer = true;
    public float tempoInicial = 0, tempoFinal;
    public GameObject contagem, pauseMenu, fade, fadeStart;
    public string cena;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==false && contagem.activeSelf==false && fadeStart.activeSelf==false) {
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
        fade.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(cena);
    }
}
