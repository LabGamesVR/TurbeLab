using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotaoHomeScript : MonoBehaviour
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

    public void OnMouseDown() {
        Time.timeScale = 1;
        ProximaFase.fase2 = 0;
        SceneManager.LoadScene(scene);
    }
}
