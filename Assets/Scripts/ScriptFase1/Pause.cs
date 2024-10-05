using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf==false) {
            Time.timeScale = 1;
        }
    }

    public void Pausar() {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
}
