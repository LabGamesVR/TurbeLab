using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptHome : MonoBehaviour
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

    public void ChangeScene() {
        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(scene);
        }
    }
}
