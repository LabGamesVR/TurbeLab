using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseMenu;
    

    public void OnMouseDown() {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
