using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PularCena : MonoBehaviour
{
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        SceneManager.LoadScene(scene);
        if(FinalizarFase1.dificuldade==1) {
            FinalizarFase1.dificuldadeF1Completada = 1;
        }
        if(FinalizarFase1.dificuldade==2) {
            FinalizarFase1.dificuldadeF1Completada = 2;
        }
        if(FinalizarFase1.dificuldade==3) {
            FinalizarFase1.dificuldadeF1Completada = 3;
        }
        Time.timeScale=1;
    }
}
