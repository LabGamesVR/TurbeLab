using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicarTubos : MonoBehaviour
{
    public GameObject somClicarTubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        somClicarTubo.SetActive(true);
    }

    void OnMouseUp() {
        somClicarTubo.SetActive(false);
    }
}
