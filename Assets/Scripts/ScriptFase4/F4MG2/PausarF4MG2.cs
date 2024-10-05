using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PausarF4MG2 : MonoBehaviour
{
    public GameObject fadeStart, fadeEnd, pauseMenu, ameba, vazio;


    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true) {
            ameba.GetComponent<BoxCollider2D>().enabled=false;
            vazio.GetComponent<BoxCollider2D>().enabled=false;
        } 
        else {
            ameba.GetComponent<BoxCollider2D>().enabled=true;
            vazio.GetComponent<BoxCollider2D>().enabled=true;
        }
    }

    void StartPhase() 
    {
        StartCoroutine("FadeStart");  
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        yield return new WaitForSeconds(2f);
    }
}
