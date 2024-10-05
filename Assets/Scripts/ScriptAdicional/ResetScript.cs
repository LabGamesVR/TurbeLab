using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    public void ResetAll()
    {
        PlayerPrefs.SetFloat("Recorde Fase1", 0f);
        PlayerPrefs.SetFloat("Recorde FaseD2_1", 0f);
        PlayerPrefs.SetFloat("Recorde FaseD3_1", 0f);
        PlayerPrefs.SetInt("Recorde Fase2", 0);
        PlayerPrefs.SetInt("Recorde FaseD2_2", 0);
        PlayerPrefs.SetInt("Recorde FaseD3_2", 0);
        PlayerPrefs.SetInt("Recorde Fase3", 0);
        PlayerPrefs.SetInt("Recorde FaseD2_3", 0);
        PlayerPrefs.SetInt("Recorde FaseD3_3", 0);
        PlayerPrefs.SetInt("Recorde Fase4", 0);
        PlayerPrefs.SetInt("Recorde FaseD2_4", 0);
        PlayerPrefs.SetInt("Recorde FaseD3_4", 0);

        PlayerPrefs.SetInt("Diff1", 0);
        PlayerPrefs.SetInt("Diff2", 0);
        PlayerPrefs.SetInt("Diff3", 0);
        PlayerPrefs.SetInt("Diff1F2", 0);
        PlayerPrefs.SetInt("Diff2F2", 0);
        PlayerPrefs.SetInt("Diff3F2", 0);
        PlayerPrefs.SetInt("Diff1F3", 0);
        PlayerPrefs.SetInt("Diff2F3", 0);
        PlayerPrefs.SetInt("Diff3F3", 0);
        PlayerPrefs.SetInt("Diff1F4", 0);
        PlayerPrefs.SetInt("Diff2F4", 0);
        PlayerPrefs.SetInt("Diff3F4", 0);
    }
}
