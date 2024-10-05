using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarF2M2 : MonoBehaviour
{
    public GameObject fadeStart, contagem, script, pause;
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        script.SetActive(false);
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartPhase() {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        script.SetActive(true);
    }

}
