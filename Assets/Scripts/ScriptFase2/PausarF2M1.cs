using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarF2M1 : MonoBehaviour
{
    public GameObject dedoInstrucao, pontilhadoInstrucao, pause, contagem, fadeEnd, fadeStart;
    public GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem.activeSelf==true || fadeEnd.activeSelf==true || fadeStart.activeSelf==true || pause.activeSelf==true) {
            player[0].GetComponent<CircleCollider2D>().enabled=false;
            player[1].GetComponent<CircleCollider2D>().enabled=false;
            player[2].GetComponent<CircleCollider2D>().enabled=false;
        } else {
            player[0].GetComponent<CircleCollider2D>().enabled=true;
            player[1].GetComponent<CircleCollider2D>().enabled=true;
            player[2].GetComponent<CircleCollider2D>().enabled=true;
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
        dedoInstrucao.SetActive(true);
        pontilhadoInstrucao.SetActive(true);
    }

}
