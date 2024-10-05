using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockF4 : MonoBehaviour
{
    public void UnlockAll()
    {
        PlayerPrefs.SetInt("Diff1", 1);
        PlayerPrefs.SetInt("Diff2", 2);
        PlayerPrefs.SetInt("Diff3", 3);
        PlayerPrefs.SetInt("Diff1F2", 1);
        PlayerPrefs.SetInt("Diff2F2", 2);
        PlayerPrefs.SetInt("Diff3F2", 3);
        PlayerPrefs.SetInt("Diff1F3", 1);
        PlayerPrefs.SetInt("Diff2F3", 2);
        PlayerPrefs.SetInt("Diff3F3", 3);
        PlayerPrefs.SetInt("Diff1F4", 1);
        PlayerPrefs.SetInt("Diff2F4", 2);
        PlayerPrefs.SetInt("Diff3F4", 3);
    }
}
