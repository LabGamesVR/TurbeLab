using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScreen : MonoBehaviour
{
    void Update()
    {
        StartCoroutine("Encerrar");
    }

    IEnumerator Encerrar()
    {
        yield return new WaitForSeconds(0.4f);
        this.gameObject.SetActive(false);
    }
}
