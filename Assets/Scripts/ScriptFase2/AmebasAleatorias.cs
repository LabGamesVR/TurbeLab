using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AmebasAleatorias : MonoBehaviour
{
    public GameObject feedBackF2M2, dedoAmebaInexistente, fade, somAcertou, Bw1Go, Bw2Go;
    public Animator Bw1, Bw2;
    public AudioSource somFaseCompletada;
    public static bool isDone = false;
    //public Text frase;
    public int x, numSorteio1, numSorteio2, numSorteio3, numSorteio4, numSorteio5, amebaDesejada;
    public GameObject[] amebaCorreta;
    public GameObject[] ameba1, ameba2, ameba3, ameba4, ameba5, amebaInexistente, amebaEscolhida, dedoAmeba;
    public static float velocidade = 4f;
    public static int dificuldadeF2M2, dedoX;
    public string scene;
    public GameObject pause, pontos, pontosNum;

    public static bool errou = false;
    void Start()
    {
        dedoX=0;
        Init();
        isDone=false;
        errou = false;
    }

    // Update is called once per frame
    async void Update() {
        if(errou==true) {
            Errou();
        }
        if(dedoX>0) {
            dedoAmebaInexistente.SetActive(false);
            for(int i=0; i<dedoAmeba.Length; i++) {
                dedoAmeba[i].SetActive(false);
            }
        }
        /*
        if(dificuldadeF2M2>=1) {
            scene="Fase2M3";
        }*/
        Reiniciar();
    }

    public void Reiniciar() {
        if(isDone==true && x<3 && ameba1[6].activeSelf==false && ameba2[6].activeSelf==false && ameba3[6].activeSelf==false && ameba4[6].activeSelf==false && ameba5[6].activeSelf==false && amebaInexistente[1].activeSelf==false) {
            F2pontuacao.pontos += 50;
            x++;
            ameba1[7].SetActive(false);
            ameba2[7].SetActive(false);
            ameba3[7].SetActive(false);
            ameba4[7].SetActive(false);
            ameba5[7].SetActive(false);
            amebaInexistente[2].SetActive(false);
            isDone=false;
            Init();
        }

        if(isDone==true && x==3 && ameba1[6].activeSelf==false && ameba2[6].activeSelf==false && ameba3[6].activeSelf==false && ameba4[6].activeSelf==false && ameba5[6].activeSelf==false && amebaInexistente[1].activeSelf==false) {
            F2pontuacao.pontos += 50;
            x++;
            ameba1[7].SetActive(false);
            ameba2[7].SetActive(false);
            ameba3[7].SetActive(false);
            ameba4[7].SetActive(false);
            ameba5[7].SetActive(false);
            amebaInexistente[2].SetActive(false);
            somAcertou.SetActive(false);
            somFaseCompletada.Play();
            PassPhase();
            //frase.text = "Boa!";
        }

        if(errou==true && x<3 && ameba1[6].activeSelf==false && ameba2[6].activeSelf==false && ameba3[6].activeSelf==false && ameba4[6].activeSelf==false && ameba5[6].activeSelf==false && amebaInexistente[1].activeSelf==false) {
            x++;
            ameba1[7].SetActive(false);
            ameba2[7].SetActive(false);
            ameba3[7].SetActive(false);
            ameba4[7].SetActive(false);
            ameba5[7].SetActive(false);
            amebaInexistente[2].SetActive(false);
            isDone=false;
            errou=false;
            Init();
        }

        if(errou==true && x==3 && ameba1[6].activeSelf==false && ameba2[6].activeSelf==false && ameba3[6].activeSelf==false && ameba4[6].activeSelf==false && ameba5[6].activeSelf==false && amebaInexistente[1].activeSelf==false) {
            x++;
            ameba1[7].SetActive(false);
            ameba2[7].SetActive(false);
            ameba3[7].SetActive(false);
            ameba4[7].SetActive(false);
            ameba5[7].SetActive(false);
            amebaInexistente[2].SetActive(false);
            somAcertou.SetActive(false);
            somFaseCompletada.Play();
            PassPhase();
            //frase.text = "Boa!";
        }
    }
//===========================================
    public void Init() {
        StartCoroutine("Amebas");
    }
    void PassPhase() {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase() {
        if(FeedConfig.feedCount>0) {
            feedBackF2M2.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF2M2.SetActive(false);
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        } else {
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        }
    }

    IEnumerator Amebas() {
        //frase.text = "Decore o número de pernas das amebas!";
        pause.SetActive(false);
        pontos.SetActive(false);
        pontosNum.SetActive(false);
        Bw1Go.SetActive(true);
        Bw2Go.SetActive(true);

        amebaEscolhida[amebaDesejada].SetActive(false);
        amebaEscolhida[0].SetActive(false);

        amebaDesejada = Random.Range(1,5);
        //yield return new WaitForSeconds(2f);
        numSorteio1 = Random.Range(1, 5);
        ameba1[numSorteio1].SetActive(true);
        numSorteio2 = Random.Range(1, 5);
        ameba2[numSorteio2].SetActive(true);
        numSorteio3 = Random.Range(1, 5);
        ameba3[numSorteio3].SetActive(true);
        if(dificuldadeF2M2>1) {
            numSorteio4 = Random.Range(1, 5);
            ameba4[numSorteio4].SetActive(true);
        }
        if(dificuldadeF2M2>2) {
            numSorteio5 = Random.Range(1, 5);
            ameba5[numSorteio5].SetActive(true);
        }


        yield return new WaitForSeconds(velocidade);
        ameba1[numSorteio1].SetActive(false);
        ameba2[numSorteio2].SetActive(false);
        ameba3[numSorteio3].SetActive(false);
        if(dificuldadeF2M2>1) {
            ameba4[numSorteio4].SetActive(false);
        }
        if(dificuldadeF2M2>2) {
            ameba5[numSorteio5].SetActive(false);
        }
        
        if(numSorteio1 != amebaDesejada && numSorteio2 != amebaDesejada && numSorteio3 != amebaDesejada && numSorteio4 != amebaDesejada && numSorteio5 != amebaDesejada) {
            amebaInexistente[1].SetActive(true);
            if(dedoX==0) {
                dedoAmebaInexistente.SetActive(true);
            }
        }

        if(numSorteio1 == amebaDesejada) {
            ameba1[6].SetActive(true);
            amebaInexistente[2].SetActive(true);
            if(dedoX==0) {
                dedoAmeba[0].SetActive(true);
            }
        } else {
            ameba1[7].SetActive(true);
        }
        if(numSorteio2 == amebaDesejada) {
            ameba2[6].SetActive(true);
            amebaInexistente[2].SetActive(true);
            if(dedoX==0) {
                dedoAmeba[1].SetActive(true);
            }
        } else {
            ameba2[7].SetActive(true);
        }
        if(numSorteio3 == amebaDesejada) {
            ameba3[6].SetActive(true);
            amebaInexistente[2].SetActive(true);
            if(dedoX==0) {
                dedoAmeba[2].SetActive(true);
            }
            
        } else {
            ameba3[7].SetActive(true);
        }
        if(dificuldadeF2M2>1) {
            if(numSorteio4 == amebaDesejada) {
                ameba4[6].SetActive(true);
                amebaInexistente[2].SetActive(true);
                if(dedoX==0) {
                    dedoAmeba[3].SetActive(true);
                }
            } else {
                ameba4[7].SetActive(true);
            }
        }
        if(dificuldadeF2M2>2) {
            if(numSorteio5 == amebaDesejada) {
                ameba5[6].SetActive(true);
                amebaInexistente[2].SetActive(true);
                if(dedoX==0) {
                    dedoAmeba[4].SetActive(true);
                }
            } else {
                ameba5[7].SetActive(true);
            }
        }
        
        //frase.text = "";//"Quais amebas tinham "+amebaDesejada.ToString()+" perna(s)?";
        amebaEscolhida[0].SetActive(true);
        amebaEscolhida[amebaDesejada].SetActive(true);
        pause.SetActive(true);
        pontos.SetActive(true);
        pontosNum.SetActive(true);
        Bw1.SetBool("reverter", true);
        Bw2.SetBool("reverter", true);
    }

    void Errou() {
        amebaCorreta[0].SetActive(false);
        amebaCorreta[1].SetActive(false);
        amebaCorreta[2].SetActive(false);
        amebaCorreta[3].SetActive(false);
        amebaCorreta[4].SetActive(false);
        amebaCorreta[5].SetActive(false);
        dedoAmebaInexistente.SetActive(false);
        dedoAmeba[0].SetActive(false);
        dedoAmeba[1].SetActive(false);
        dedoAmeba[2].SetActive(false);
        dedoAmeba[3].SetActive(false);
        dedoAmeba[4].SetActive(false);
    }
}