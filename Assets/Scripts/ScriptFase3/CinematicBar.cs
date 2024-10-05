using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicBar : MonoBehaviour
{
    public Animator Bw1, Bw2;
    public GameObject Bw1GO, Bw2GO, GroupCol;
    public GameObject pause, pontos, pontosNum, base_front;

    public static bool canRevert = false;
    void Start()
    {
        StartCoroutine(ActiveSequence());
        Bw1GO.SetActive(true);
        Bw2GO.SetActive(true);
        pause.SetActive(false);
        pontos.SetActive(false);
        pontosNum.SetActive(false);
    }

    private void Update()
    {
        if(canRevert == true)
        {
            Bw1.SetBool("reverter", true);
            Bw2.SetBool("reverter", true);
            pause.SetActive(true);
            pontos.SetActive(true);
            pontosNum.SetActive(true);
            canRevert = false;
        }
        else
        {
            Bw1.SetBool("reverter", false);
            Bw2.SetBool("reverter", false);
        }
    }

    IEnumerator ActiveSequence()
    {
        yield return new WaitForSeconds(2f);
        base_front.SetActive(false);
    }
}
