using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeF3M3 : MonoBehaviour
{
    public float time;
    void Start()
    {
        if (IniciarFase3.easy == 1)
        {
            time = 30f;
            RandomizeSequence.time = 6f;
        }
        else if (IniciarFase3.medium == 1)
        {
            time = 27.5f;
            RandomizeSequence.time = 5f;
        }
        else if (IniciarFase3.hard == 1)
        {
            time = 25f;
            RandomizeSequence.time = 4f;
        }
    }

    void Update()
    {
        time -= 1 * Time.deltaTime;
    }
}
