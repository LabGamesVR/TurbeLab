using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject curiosidade;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        if(curiosidade.activeSelf==false){
           curiosidade.SetActive(true); 
        } else{
            curiosidade.SetActive(false);
        }
    }
}
