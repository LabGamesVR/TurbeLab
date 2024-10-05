using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSequence : MonoBehaviour
{
    [SerializeField]
    List<Transform> positions = new List<Transform>();

    [SerializeField]
    SequenceValidation _Sequence;

    public static float time;

    public GameObject[] objs;

    [SerializeField]
    GameObject[] coliders;

    [SerializeField]
    GameObject groupCol;

    public GameObject contagem, pauseMenu, fadeEnd, fadeStart;

    int count = 8;

    int rand;

    bool canSequence, canSequenceSecondKey = true;
    void Update()
    {
        if (contagem.activeSelf == true || fadeEnd.activeSelf == true || fadeStart.activeSelf == true)
        {
            canSequence = false;
        }
        else
        {
            canSequence = true;
        }

        if(canSequence == true && canSequenceSecondKey == true)
        {
            Sequence();
        }

    }

    public void Sequence()
    {
        for (int i = 0; i < 8; i++)
        {
            CreateRandom(rand);
            objs[i].transform.localPosition = positions[rand].localPosition;
            coliders[i].transform.localPosition = positions[rand].localPosition;
            positions.Remove(positions[rand]);
            count--;
            if(i == 7)
            {
                StartCoroutine("DesativarSequencia");
            }
        }
        canSequenceSecondKey = false;
    }

    void CreateRandom(int random)
    {
        random = rand;
        rand = Random.Range(0, count);
    }

    IEnumerator DesativarSequencia()
    {
        yield return new WaitForSeconds(time);
        for (int i = 0; i < 8; i++)
        {
            objs[i].SetActive(false);
        }
        groupCol.SetActive(true);
        _Sequence.ValidationVariable = true;
        time = 0;
        CinematicBar.canRevert = true;
    }

    private void LateUpdate()
    {
        StartCoroutine("Atraso");
    }

    IEnumerator Atraso()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < coliders.Length; i++)
        {
            if (objs[i].activeSelf == true)
            {
                coliders[i].SetActive(false);
            }
            else
            {
                coliders[i].SetActive(true);
            }
        }
    }
}
