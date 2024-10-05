using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScenes : MonoBehaviour
{
    public string scene;

    void Start () {

    }

    void Update () {

    }

    void OnMouseUp() {
        SceneManager.LoadScene(scene);
        Pontuacao.pontos = 0;
    }

}
