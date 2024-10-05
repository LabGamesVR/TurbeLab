using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarF4MG1 : MonoBehaviour
{
    public GameObject fadeStart, fadeEnd, contagem, script, pauseMenu;
    public GameObject[] gameObjects;

    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (pauseMenu.activeSelf == true || fadeEnd.activeSelf == true || fadeStart.activeSelf == true)
            {
                // Acesse o componente "MoveObjects" de cada objeto.
                gameObjects[i].GetComponent<MoveObject>().enabled = false;
            }
            else
            {
                gameObjects[i].GetComponent<MoveObject>().enabled = true;
            }
        }
    }

    void StartPhase()
    {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart()
    {
        yield return new WaitForSeconds(2f);
        fadeStart.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        script.SetActive(true);
    }
}
