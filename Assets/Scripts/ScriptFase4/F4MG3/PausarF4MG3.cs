using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PausarF4MG3 : MonoBehaviour
{
    public GameObject fadeStart, fadeEnd, contagem, pauseMenu, botoes;
    private bool botoesAtivados;


    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem.activeSelf==true || pauseMenu.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true) {
            botoes.SetActive(false);
            botoesAtivados = false;
        } 
        else {
            if(botoesAtivados==false)
            {
                botoes.SetActive(true);
                botoesAtivados = true;
            }
            
        }
    }

    void StartPhase() 
    {
        StartCoroutine("FadeStart");  
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
    }
}
