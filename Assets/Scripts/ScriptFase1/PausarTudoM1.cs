using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausarTudoM1 : MonoBehaviour
{
    public GameObject linhaTimer, linha, liquido, contagem, pauseMenu, fadeEnd, fadeStart;
    public GameObject[] dedos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==true || contagem.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true) {
            liquido.GetComponent<PinchScript>().enabled=false;
            linhaTimer.GetComponent<Timer>().enabled=false;
        } else {
            liquido.GetComponent<PinchScript>().enabled=true;
            linhaTimer.GetComponent<Timer>().enabled=true;
        }
    }

    void StartPhase() {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
        dedos[0].SetActive(true);
        dedos[1].SetActive(true);
    }

}
