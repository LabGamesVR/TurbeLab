using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string scene;
    public void OnMouseDown() 
    {
        SceneManager.LoadScene(scene);
    }
}
