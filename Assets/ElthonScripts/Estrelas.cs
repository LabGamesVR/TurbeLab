using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrelas : MonoBehaviour
{
    public Animator estrelas1;
    public void MakeItStop()
    {
        estrelas1.SetBool("Stars", false);
    }
}
