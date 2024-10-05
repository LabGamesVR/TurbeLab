using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinchScript : MonoBehaviour
{
    
    public GameObject dedo1, dedo2, linha;
    public GameObject liquido;
    public GameObject som, somPontuando;
    public float diferenca;

    [SerializeField]
    Animator estrelas1;
    [SerializeField]
    Animator linha2;

    private void Start()
    {
        StartCoroutine("StartingAnim");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2) 
        {
            dedo1.SetActive(false);
            dedo2.SetActive(false);
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;
            diferenca = difference;

            if(diferenca==0) 
            {
                liquido.transform.localScale += new Vector3(0f, 0.003f, 0f);
            }

            liquido.transform.localScale += new Vector3(0f, difference*0.0025f, 0f);

            if(liquido.transform.localScale.y<-1.5f) 
            {
                liquido.transform.localScale = new Vector3(0.1f, -1.5f, 0f);
            }
            if(liquido.transform.localScale.y>-0.5f) 
            {
                liquido.transform.localScale = new Vector3(0.1f, -0.5f, 0f);
            }

            if(difference>0) 
            {
                som.SetActive(true);
                som.GetComponent<AudioSource>().pitch=-1;
            } 
            else if(difference<0) 
            {
                som.SetActive(true);
                som.GetComponent<AudioSource>().pitch=1;
            }

            linha2.SetBool("InLine", false);
        } 

        else 
        {
            liquido.transform.localScale += new Vector3(0f, 0.003f, 0f);
            StartCoroutine("PayAttention");

            if (liquido.transform.localScale.y>=-0.5f) 
            {
                liquido.transform.localScale = new Vector3(0.1f, -0.5f, 0f);
                som.SetActive(false);
            } 
            else 
            {
                som.GetComponent<AudioSource>().pitch=-1;
                som.SetActive(true);
            }
        }

        if(liquido.transform.localScale.y > linha.transform.localScale.y-0.035f  && liquido.transform.localScale.y < linha.transform.localScale.y+0.035f) 
        {
            Pontuacao.pontos += 1f;
            som.SetActive(false);
            somPontuando.SetActive(true);

            estrelas1.SetBool("Stars", true);
        }
        else 
        {
            somPontuando.SetActive(false);

            estrelas1.SetBool("Stars", false);
        }
    }

    IEnumerator PayAttention()
    {
        yield return new WaitForSeconds(7f);
        linha2.SetBool("InLine", true);
    }
    IEnumerator StartingAnim()
    {
        Contagem.canAnimate = true;
        yield return new WaitForSeconds(4f);
        if (Contagem.canAnimate == true)
        {
            linha2.SetBool("Animate", true);
            yield return new WaitForSeconds(1f);
            linha2.SetBool("Animate", false);
            Contagem.canAnimate = false;
        }
    }
}
