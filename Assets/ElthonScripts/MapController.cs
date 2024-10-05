using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    
    void Update()
    {
        //Fase 1
        if (FinalizarFase1.dificuldade == 1)
        {
            FinalizarFase1.dificuldadeF1Completada = 1;
            PlayerPrefs.SetInt("Diff1F1", FinalizarFase1.dificuldadeF1Completada);
        }
        if (FinalizarFase1.dificuldade == 2)
        {
            FinalizarFase1.dificuldadeF1Completada = 2;
            PlayerPrefs.SetInt("Diff2F1", FinalizarFase1.dificuldadeF1Completada);
        }
        if (FinalizarFase1.dificuldade == 3)
        {
            FinalizarFase1.dificuldadeF1Completada = 3;
            PlayerPrefs.SetInt("Diff3F1", FinalizarFase1.dificuldadeF1Completada);
        }
        //Fase 2
        if (IniciarFase2.dificuldade == 1)
        {
            FinalizarFase2.dificuldadeF2Completada = 1;
            PlayerPrefs.SetInt("Diff1F2", FinalizarFase2.dificuldadeF2Completada);
        }
        if (IniciarFase2.dificuldade == 2)
        {
            FinalizarFase2.dificuldadeF2Completada = 2;
            PlayerPrefs.SetInt("Diff2F2", FinalizarFase2.dificuldadeF2Completada);
        }
        if (IniciarFase2.dificuldade == 3)
        {
            FinalizarFase2.dificuldadeF2Completada = 3;
            PlayerPrefs.SetInt("Diff3F2", FinalizarFase2.dificuldadeF2Completada);
        }
        //Fase 3
        if (IniciarFase3.dificuldade == 1)
        {
            FinalizarFase3.dificuldadeF3Completada = 1;
            PlayerPrefs.SetInt("Diff1F3", FinalizarFase3.dificuldadeF3Completada);
        }
        if (IniciarFase3.dificuldade == 2)
        {
            FinalizarFase3.dificuldadeF3Completada = 2;
            PlayerPrefs.SetInt("Diff2F3", FinalizarFase3.dificuldadeF3Completada);
        }
        if (IniciarFase3.dificuldade == 3)
        {
            FinalizarFase3.dificuldadeF3Completada = 3;
            PlayerPrefs.SetInt("Diff3F3", FinalizarFase3.dificuldadeF3Completada);
        }
        //Fase 4
        if (IniciarFase4.dificuldade == 1)
        {
            FinalizarFase4.dificuldadeF4Completada = 1;
            PlayerPrefs.SetInt("Diff1F3", FinalizarFase4.dificuldadeF4Completada);
        }
        if (IniciarFase3.dificuldade == 2)
        {
            FinalizarFase4.dificuldadeF4Completada = 2;
            PlayerPrefs.SetInt("Diff2F3", FinalizarFase4.dificuldadeF4Completada);
        }
        if (IniciarFase3.dificuldade == 3)
        {
            FinalizarFase4.dificuldadeF4Completada = 3;
            PlayerPrefs.SetInt("Diff3F3", FinalizarFase4.dificuldadeF4Completada);
        }
    }
}
