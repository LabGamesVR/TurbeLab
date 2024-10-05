using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SequenceValidation : MonoBehaviour
{
    [SerializeField]
    RandomizeSequence RandSeq;

    [SerializeField]
    GameObject stars, damage;

    public AudioSource somCerto;
    public AudioSource somErrado;
    public AudioSource somCompleto;

    public GameObject fade, feedBackF3M3;
    public TimeF3M3 timer;

    public GameObject contagem, pauseMenu, fadeEnd, fadeStart;

    public List<GameObject> Selecionados = new List<GameObject>();

    public int count = 0, diff3Points = 0, contadorDiff3;

    public static int dificuldade;
    [SerializeField]
    GameObject[] objetos;

    public bool ValidationVariable = false;

    int c = 0;
    public void Validate1()
    {
        if (RandSeq.objs[0].activeSelf == true)
        {
            if (RandSeq.objs[1].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                Debug.Log(Selecionados.Count);
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[1].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }

        else if (RandSeq.objs[1].activeSelf == true)
        {
            if (RandSeq.objs[0].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                Debug.Log(Selecionados.Count);
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                c++;
                count = 0;
            }
            else if (RandSeq.objs[0].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }
    }

    public void Validate2()
    {
        if (RandSeq.objs[2].activeSelf == true)
        {
            if (RandSeq.objs[3].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[3].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }

        else if (RandSeq.objs[3].activeSelf == true)
        {
            if (RandSeq.objs[2].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[2].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }
    }

    public void Validate3()
    {
        if (RandSeq.objs[4].activeSelf == true)
        {
            if (RandSeq.objs[5].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[5].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }

        else if (RandSeq.objs[5].activeSelf == true)
        {
            if (RandSeq.objs[4].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[4].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }
    }

    public void Validate4()
    {
        if (RandSeq.objs[6].activeSelf == true)
        {
            if (RandSeq.objs[7].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if(dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[7].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }

        if (RandSeq.objs[7].activeSelf == true)
        {
            if (RandSeq.objs[6].activeSelf == true && count == 2)
            {
                stars.SetActive(true);
                StartCoroutine(RemoverItens());
                c++;
                if (dificuldade == 1)
                {
                    F3Pontuacao.pontos += 50;
                }
                else if (dificuldade == 2)
                {
                    F3Pontuacao.pontos += 50;
                }
                somCerto.Play();
                count = 0;
            }
            else if (RandSeq.objs[6].activeSelf == false && count == 2)
            {
                damage.SetActive(true);
                somErrado.Play();
                if (dificuldade == 3)
                {
                    StartCoroutine("ErroDiff3");
                    diff3Points = 0;
                    c = 0;
                }
                else
                {
                    StartCoroutine("ErroDiff1_2");
                }
                count = 0;
            }
        }
    }

    private void Update()
    {
        if(dificuldade == 1)
        {
            RandomizeSequence.time = 7f;
        }
        else if (dificuldade >= 2)
        {
            RandomizeSequence.time = 4f;
        }
        if (ValidationVariable == true)
        {
            if(c >= 4)
            {
                if(dificuldade == 3 && c >= 4)
                {
                    for(int i = 0; i < objetos.Length; i++)
                    {
                        if(objetos[i].activeSelf == true)
                        {
                            contadorDiff3 += 1;
                        }
                        else
                        {
                            contadorDiff3 = 0;
                        }
                    }
                    if(contadorDiff3 >= 8)
                    {
                        F3Pontuacao.pontos += 200;
                        contadorDiff3 = 0;
                    }
                }
                somCompleto.Play();
                PassPhase();
                c = 0;
            }
        }

        if (timer.time <= 0)
        {
            PassPhase();
        }
    }

    void PassPhase()
    {
        StartCoroutine("PularFase");
    }

    IEnumerator PularFase()
    {
        if (FeedConfig.feedCount > 0)
        {
            feedBackF3M3.SetActive(true);
            yield return new WaitForSeconds(3f);
            feedBackF3M3.SetActive(false);
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("FinalizacaoF3");
        }
        else
        {
            fade.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("FinalizacaoF3");
        }
    }

    IEnumerator ErroDiff3()
    {
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < 8; i++)
        {
            RandSeq.objs[i].SetActive(false);
        }
    }

    IEnumerator ErroDiff1_2()
    {
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < 2; i++)
        {
            Selecionados[i].SetActive(false);
        }
        StartCoroutine(RemoverItens());
    }

    IEnumerator RemoverItens()
    {
        yield return new WaitForSeconds(0.2f);
        Selecionados.Clear();
        Debug.Log(Selecionados.Count);
    }
}
