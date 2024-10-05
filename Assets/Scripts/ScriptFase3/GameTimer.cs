using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float time;
    public F3M2Controller F3M2C;
    void Update()
    {
        if (IniciarFase3.easy == 1)
        {
            time = 30f;
        }
        else if (IniciarFase3.medium == 1)
        {
            time = 27.5f;
        }
        else if (IniciarFase3.hard == 1)
        {
            time = 25f;
        }
        time -= 1 * Time.deltaTime;

        if(time <= 0)
        {
            F3M2C.NextScene();
        }
    }
}
