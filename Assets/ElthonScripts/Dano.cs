using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public Animator fadeRed;
    
    public void MakeItStop()
    {
        fadeRed.SetBool("Damage", false);
    }
}
