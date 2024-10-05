using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public float delayInSeconds = 2f;
    public string sceneName;

    void Start()
    {
        Invoke("ChangeScene", delayInSeconds);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
