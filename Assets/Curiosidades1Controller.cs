using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curiosidades1Controller : MonoBehaviour
{
    public GameObject[] faseCheck, texto, tracoEscuro;
    public GameObject cadeado;
    public int i;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(texto[i].activeSelf==false) {
            cadeado.SetActive(true);
        } else {
            cadeado.SetActive(false);
        }
        ChecarCuriosidades();
    }

    public void Previous() {
        if(i>0) {
            i--;
            tracoEscuro[i].SetActive(true);
            texto[i].GetComponent<Image>().color = new Color(1, 1, 1, 1);
            tracoEscuro[i+1].SetActive(false);
            texto[i+1].GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }

    public void Next() {
        if(i<2) {
            i++;
            tracoEscuro[i].SetActive(true);
            texto[i].GetComponent<Image>().color = new Color(1, 1, 1, 1);
            tracoEscuro[i-1].SetActive(false);
            texto[i-1].GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }

    void ChecarCuriosidades() {
        if(faseCheck[0].activeSelf==true) {
            texto[0].SetActive(true);
        }
        if(faseCheck[1].activeSelf==true) {
            texto[1].SetActive(true);
        }
        if(faseCheck[2].activeSelf==true) {
            texto[2].SetActive(true);
        }
    }

}