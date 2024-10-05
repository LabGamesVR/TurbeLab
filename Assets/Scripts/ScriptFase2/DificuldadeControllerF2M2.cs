using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificuldadeControllerF2M2 : MonoBehaviour
{
    public GameObject ameba1, ameba2, ameba3, ameba4, ameba5, segurarAmeba1, segurarAmeba2;
    // Start is called before the first frame update
    void Start()
    {
        if(AmebasAleatorias.dificuldadeF2M2==1) {
            ameba1.transform.position = new Vector3(ameba4.transform.position.x, ameba4.transform.position.y, 0);
            ameba3.transform.position = new Vector3(ameba5.transform.position.x, ameba5.transform.position.y, 0);
        }
        if(AmebasAleatorias.dificuldadeF2M2==2) {
            ameba1.transform.position = new Vector3(segurarAmeba1.transform.position.x, segurarAmeba1.transform.position.y, 0);
            ameba2.transform.position = new Vector3(segurarAmeba2.transform.position.x, segurarAmeba2.transform.position.y, 0);
            ameba3.transform.position = new Vector3(ameba5.transform.position.x, ameba5.transform.position.y, 0);
        }
        if(AmebasAleatorias.dificuldadeF2M2>1) {
            ameba4.SetActive(true);
        }
        if(AmebasAleatorias.dificuldadeF2M2>2) {
            ameba5.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
