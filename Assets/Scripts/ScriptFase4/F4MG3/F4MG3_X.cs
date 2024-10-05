using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F4MG3_X : MonoBehaviour
{
    public float velocidade = 1f; // velocidade de movimento da imagem
    public float minX = -0.2f; // limite mínimo no eixo X
    public float maxX = 0.2f; // limite máximo no eixo X
    public float minY = -0.2f; // limite mínimo no eixo Y
    public float maxY = 0.2f; // limite máximo no eixo Y
    public Animator animX;
    public Animator animY;

    private Image imagem; // referência para o componente Image
    private Vector3 posicaoInicial; // posição inicial da imagem
    private bool isMovingY = false; // variável para controlar se o usuário está movendo a imagem no eixo Y
    private bool isMovingX = false; // variável para controlar se o usuário está movendo a imagem no eixo X
    private float directionY = 0f; // direção de movimento no eixo Y
    private float directionX = 0f; // direção de movimento no eixo X
    private bool isClickedX = false;
    private bool isClickedY = false;


    // Start is called before the first frame update
    void Start()
    {
        imagem = GetComponent<Image>(); // obtém o componente Image
        posicaoInicial = transform.position; // salva a posição inicial da imagem
    }


    // método para mover a imagem A para cima ou para baixo
    public void MoverEixoY(float direcao)
    {
        directionY = direcao;
        isMovingY = true;
        isClickedY = true;
    }

    // método para mover a imagem B para esquerda ou direita
    public void MoverEixoX(float direcao)
    {
        directionX = direcao;
        isMovingX = true;
        isClickedX = true;  
    }

    // método para interromper o movimento no eixo Y quando o usuário solta o botão
    public void PararMoverEixoY()
    {
        isMovingY = false;
        isClickedY = false;     
    }

    // método para interromper o movimento no eixo X quando o usuário solta o botão
    public void PararMoverEixoX()
    {
        isMovingX = false;
        isClickedX = false;     
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingY)
        {
            float movimentoY = directionY * velocidade * Time.deltaTime;

            // move a imagem somente dentro dos limites definidos
            float novaPosicaoY = Mathf.Clamp(transform.position.y + movimentoY, minY, maxY);

            transform.position = new Vector3(transform.position.x, novaPosicaoY, posicaoInicial.z);
        }

        if (isMovingX)
        {
            float movimentoX = directionX * velocidade * Time.deltaTime;

            // move a imagem somente dentro dos limites definidos
            float novaPosicaoX = Mathf.Clamp(transform.position.x + movimentoX, minX, maxX);

            transform.position = new Vector3(novaPosicaoX, transform.position.y, posicaoInicial.z);
        }
        
        if (isClickedX)
        {
            animX.SetBool("isClicked", true);
        }
        else
        {
            animX.SetBool("isClicked", false);
        }

        if (isClickedY)
        {
            animY.SetBool("isClicked", true);
        }
        else
        {
            animY.SetBool("isClicked", false);
        }
        
    }
}





