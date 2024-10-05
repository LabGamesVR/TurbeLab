using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedLevel : MonoBehaviour
{
    [SerializeField] GameObject frase;

    public void CallIE()
    {
        StartCoroutine("AtivaFrase");
    }
    IEnumerator AtivaFrase()
    {
        frase.SetActive(true);
        yield return new WaitForSeconds(6f);
        frase.SetActive(false);
    }
}
