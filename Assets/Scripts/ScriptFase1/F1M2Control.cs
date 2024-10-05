using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F1M2Control : MonoBehaviour
{
    public GameObject feedBackF1M2, somFaseCompletada;
    public static int i;
    public string scene;
    public GameObject fadeEnd;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(i>=4) {
            PassPhase();
        }
    }

    void PassPhase() {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase() {
        somFaseCompletada.SetActive(true);
        if(FeedConfig.feedCount>0) {
            feedBackF1M2.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF1M2.SetActive(false);
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

