using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curiosidades : MonoBehaviour
{
    public GameObject informacao, curiosidadePanel, cadeado;
    public GameObject[] checkF1, checkF2, curiosidade;
    public int i;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(curiosidade[i].activeSelf==false) {
            cadeado.SetActive(true);
        } else {
            cadeado.SetActive(false);
        }
        ChecarCuriosidades();
    }

    public void Next()
    {
        if(i<=curiosidade.Length-2){
            i++;
        }
        curiosidade[i].GetComponent<Image>().color = new Color(1, 1, 1, 1);
        curiosidade[i-1].GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    public void Previous()
    {
        if(i>=1){
            i--;
        }
        curiosidade[i].GetComponent<Image>().color = new Color(1, 1, 1, 1);
        curiosidade[i+1].GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    public void ChecarCuriosidades() {
        if(checkF1[0].activeSelf==true) {
            curiosidade[0].SetActive(true);
        }
        if(checkF1[1].activeSelf==true) {
            curiosidade[1].SetActive(true);
        }
        if(checkF1[2].activeSelf==true) {
            curiosidade[2].SetActive(true);
        }
        if(checkF2[0].activeSelf==true) {
            curiosidade[3].SetActive(true);
        }
        if(checkF2[1].activeSelf==true) {
            curiosidade[4].SetActive(true);
        }
        if(checkF2[2].activeSelf==true) {
            curiosidade[5].SetActive(true);
        }
    }
}