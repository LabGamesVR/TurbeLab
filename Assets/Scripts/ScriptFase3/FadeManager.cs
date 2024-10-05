using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour
{
    public GameObject contagem, pauseMenu, fadeEnd, fadeStart, CinematicBar;
    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    void StartPhase()
    {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart()
    {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        CinematicBar.SetActive(true);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
    }

}
