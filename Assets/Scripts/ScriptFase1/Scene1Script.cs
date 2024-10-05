using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1Script : MonoBehaviour
{
    public Text textPerdeu;
    public Text textGanhou;
    bool continuarTimer = true;
    public GameObject botao;
    public float tempoInicial = 0;
    public float tempoFinal = 5;

    // Start is called before the first frame update
    void Start()
    {
        textGanhou.enabled = false;
        textPerdeu.enabled = false;
        botao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(continuarTimer) {
            tempoInicial += (1*Time.deltaTime);
            if (tempoInicial>tempoFinal){
                continuarTimer = false;
                textGanhou.enabled = true;
                Debug.Log("Ganhou! vida++");
                botao.SetActive(true);
            } else {
                if(Input.GetMouseButtonDown(0)) {
                    continuarTimer = false;
                    textPerdeu.enabled = true;
                    Debug.Log("Perdeu! vida--");
                    botao.SetActive(true);
                }
            }
        }

        /*if(Input.GetMouseButtonDown(0)) {
            x = Random.Range(-4.5f, 4.5f);
            y = Random.Range(-4.5f, 4.5f);
            var pos = new Vector3(x, y, 0);
            transform.position = pos;
        }*/
    }

}
