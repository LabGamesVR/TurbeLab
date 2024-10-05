using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject nextCheck;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            nextCheck.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
