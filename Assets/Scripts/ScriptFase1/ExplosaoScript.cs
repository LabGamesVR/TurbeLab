using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplosaoScript : MonoBehaviour
{
    public bool clicavel=false;
    public GameObject feedBackF1M3, somFaseCompletada;
    public GameObject[] explosoes;
    public GameObject[] tubosAtivos;
    public GameObject[] tubosInativos;
    public GameObject somExplosao, fadeEnd, wall1, wall2;
    public int numSorteio;
    public static int cliques, quantidade = 4, dedo;
    public ArrayList array =  new ArrayList();
    public static int i = 0;
    public string scene;
    public Animator Bw1, Bw2;
    public GameObject pause, pontos, pontosNum;

    void Start() 
    {
        i = 0;
        clicavel=false;
        cliques = 0;
        StartCoroutine("Explosoes");
    }

    // Update is called once per frame
    void Update()
    {
        if(Contagem.canAnimate == true)
        {
            pause.SetActive(false);
            pontos.SetActive(false);
            pontosNum.SetActive(false);
            wall1.SetActive(true);
            wall2.SetActive(true);
            Contagem.canAnimate = false;
        }

        if(clicavel==true) {
            if(tubosAtivos[0].activeSelf==true){
                tubosInativos[0].SetActive(false);
            } else {
                tubosInativos[0].SetActive(true);
            }
            if(tubosAtivos[1].activeSelf==true){
                tubosInativos[1].SetActive(false);
            } else {
                tubosInativos[1].SetActive(true);
            }
            if(tubosAtivos[2].activeSelf==true){
                tubosInativos[2].SetActive(false);
            } else {
                tubosInativos[2].SetActive(true);
            }
            if(tubosAtivos[3].activeSelf==true){
                tubosInativos[3].SetActive(false);
            } else {
                tubosInativos[3].SetActive(true);
            }
        }

        if(cliques == quantidade + 1) {
            PassPhase();
        }
        if(i>0 && i<=quantidade && tubosAtivos[(int)(array[i-1])].activeSelf==false) {
            tubosAtivos[(int)(array[i])].SetActive(true);
        }


        
        /*if(tubosInativos[0].activeSelf==true && tubosInativos[1].activeSelf==true && tubosInativos[2].activeSelf==true && tubosInativos[3].activeSelf==true 
        && tubosAtivos[0].activeSelf==false && tubosAtivos[1].activeSelf==false && tubosAtivos[2].activeSelf==false && tubosAtivos[3].activeSelf==false) {
            PassPhase();
        }*/
    }

    IEnumerator Explosoes() 
    {
        for (int i = 0; i<=quantidade; i++) 
        {
            yield return new WaitForSeconds(0.7f);
            numSorteio = Random.Range(0, explosoes.Length);
            array.Add(numSorteio);
            explosoes[numSorteio].SetActive(true);
            somExplosao.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            somExplosao.SetActive(false);
            explosoes[numSorteio].SetActive(false);
        }

        //yield return new WaitForSeconds(2f);
        for(int i=0; i<=quantidade; i++) 
        {
            Debug.Log(array[i].ToString());
        }

        yield return new WaitForSeconds(1f);

        /*for(int i=0; i<4; i++) {
            tubosInativos[i].SetActive(true);
        }*/

        if(i==0) //O erro est� aqui <-------------------
        {
            clicavel=true;
            Bw1.SetBool("reverter", true);
            Bw2.SetBool("reverter", true);
            pause.SetActive(true);
            pontos.SetActive(true);
            pontosNum.SetActive(true);
            dedo = 0;
            Debug.Log("Clicavel");
            tubosAtivos[(int)(array[i])].SetActive(true);
        }

    }

    void PassPhase() {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase()
    {
        
        somFaseCompletada.SetActive(true);
        if(FeedConfig.feedCount>0) {
            feedBackF1M3.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF1M3.SetActive(false);  
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        } else {
            fadeEnd.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(scene);
        }
    }

}