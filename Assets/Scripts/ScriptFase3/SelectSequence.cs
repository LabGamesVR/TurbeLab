using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSequence : MonoBehaviour
{
    [SerializeField]
    RandomizeSequence RandSeq;

    [SerializeField]
    GameObject block;

    [SerializeField]
    int item;

    [SerializeField]
    GameObject ObjCorrespondente, dedo, timer;

    public GameObject[] coliders;

    [SerializeField]
    SequenceValidation SeqValid;

    public GameObject contagem, pauseMenu, fadeEnd, fadeStart;

    private void Start()
    {
        dedo.SetActive(true);
    }
    private void OnMouseDown()
    {
        timer.SetActive(true);
        
        dedo.SetActive(false);
        RandSeq.objs[item].SetActive(true);

        block.SetActive(true);

        SeqValid.count++;

        if(item == 0 || item == 1)
        {
            SeqValid.Validate1();
            Adiciona();
        }

        else if (item == 2 || item == 3)
        {
            SeqValid.Validate2();
            Adiciona();
        }

        else if (item == 4 || item == 5)
        {
            SeqValid.Validate3();
            Adiciona();
        }

        else if (item == 6 || item == 7)
        {
            SeqValid.Validate4();
            Adiciona();
        }
    }
    public void Adiciona()
    {
        if(ObjCorrespondente.activeSelf == true)
        {
            SeqValid.Selecionados.Add(ObjCorrespondente);
            Debug.Log(SeqValid.Selecionados.Count);
        }
    }
}
