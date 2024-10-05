using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Declaração de variáveis públicas acessíveis no Unity Inspector
    public GameObject[] gameObjects; // Os objetos que serão arrastados
    public GameObject EndFade, somAcertou, Bw1Go, Bw2Go, estrelas1, pause, Organize, pontos, pontosNum, FeedbackPanel, Timer;
    public AudioSource somClicarErrou, somClicarAcertou, somCurtoCircuito, somFaseCompleta;
    public Animator fadeRed, Bw1, Bw2;
    public Animator[] Brilhos;
    public float blackoutDuration = 5f; // Duração do período de tela preta
    public int correctPlacementPoints = 50; // Pontos ao posicionar um objeto corretamente
    public int incorrectPlacementPoints = -15; // Pontos ao posicionar um objeto incorretamente
    public int score = 0; // Pontuação atual do jogador
    public Text scoreText;

    private Vector3[] originalPositions; // As posições originais dos objetos
    private Vector3[] dragPositions; // As posições atuais dos objetos
    private bool isGameActive = false;
    private int numObj;

    void Start()
    {
        // Inicialização das posições originais e atuais dos objetos
        originalPositions = new Vector3[gameObjects.Length];
        dragPositions = new Vector3[gameObjects.Length];

        for (int i = 0; i < gameObjects.Length; i++)
        {
            originalPositions[i] = gameObjects[i].transform.position;
            gameObjects[i].GetComponent<Collider2D>().enabled = false;
        }

        // Obtém o número de artefatos da fase de outra classe (IniciarFase4) e inicia a fase
        numObj = IniciarFase4.numArtefatos;
        StartCoroutine(StartLevel());
    }

    void Update()
    {
        // Atualiza a pontuação exibida na UI e verifica se o jogador concluiu a fase
        scoreText.text = score.ToString();

        if (isGameActive)
        {
            if (CheckLevelCompletion())
            {
                // Desativa os colliders dos objetos e exibe um painel de feedback
                for (int i = 0; i < gameObjects.Length; i++)
                {
                    gameObjects[i].GetComponent<Collider2D>().enabled = false;
                }
                // Salva a pontuação atual do jogador usando PlayerPrefs
                PlayerPrefs.SetInt("PontuacaoF4", score);
                PlayerPrefs.Save();
                somFaseCompleta.Play();
                if (FeedConfig.feedCount > 0)
                {
                    FeedbackPanel.SetActive(true);
                    Timer.SetActive(true);
                }
                else
                {
                    Timer.SetActive(true);
                }
            }
        }
    }

    IEnumerator StartLevel()
    {
        ShuffleOriginalPositions();

        // Torna visíveis apenas um número específico de objetos na fase
        for (int i = 0; i < gameObjects.Length; i++)
        {
            SpriteRenderer renderer = gameObjects[i].GetComponent<SpriteRenderer>();
            if (renderer != null)
            {
                renderer.enabled = (i < numObj);
            }
        }

        if (numObj == 4)
        {
            // Aguarda por 4 segundos antes de iniciar a fase
            yield return new WaitForSeconds(4f);
            Debug.Log("4");
        }
        if (numObj == 7)
        {
            // Aguarda por 5 segundos antes de iniciar a fase
            yield return new WaitForSeconds(5f);
            Debug.Log("5");
        }
        if (numObj == 9)
        {
            // Aguarda por 6 segundos antes de iniciar a fase
            yield return new WaitForSeconds(6f);
            Debug.Log("6");
        }

        // Configuração inicial da fase
        pontos.SetActive(false);
        pontosNum.SetActive(false);
        Bw1Go.SetActive(true);
        Bw2Go.SetActive(true);

        // Aguarda por mais 3 segundos
        yield return new WaitForSeconds(3f);
        pontos.SetActive(true);
        pontosNum.SetActive(true);
        Bw1.SetBool("reverter", true);
        Bw2.SetBool("reverter", true);

        // Inicia o período de tela preta
        StartCoroutine(BlackoutCoroutine());

        isGameActive = true;
    }

    IEnumerator BlackoutCoroutine()
    {
        // Reproduz o som de curto-circuito
        somCurtoCircuito.Play();

        // Repete um efeito de tela preta várias vezes
        for (int i = 0; i < 3; i++)
        {
            float fadeInDuration = Random.Range(0.4f, 0.7f);
            float fadeOutDuration = Random.Range(0.4f, 0.7f);

            somCurtoCircuito.Play();

            // Ativa o efeito de tela preta com fadeIn e depois desativa com fadeOut
            EndFade.SetActive(true);
            yield return new WaitForSeconds(fadeInDuration);
            EndFade.SetActive(false);
            yield return new WaitForSeconds(fadeOutDuration);
        }

        EndFade.SetActive(true);

        // Espera por um tempo aleatório antes de continuar
        float randomDelay = Random.Range(1f, 4f);
        yield return new WaitForSeconds(randomDelay);

        // Embaralha as posições dos objetos
        ShufflePositions();

        EndFade.SetActive(false);
        Organize.SetActive(true);

        // Ativa os colliders dos objetos
        if (Organize)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].GetComponent<Collider2D>().enabled = true;
            }
        }

        yield return new WaitForSeconds(2f);
        Organize.SetActive(false);
    }

    void ShuffleOriginalPositions()
    {
        List<Vector3> positions = new List<Vector3>(originalPositions);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            int randomIndex = Random.Range(0, positions.Count);
            gameObjects[i].transform.position = positions[randomIndex];
            originalPositions[i] = positions[randomIndex];
            positions.RemoveAt(randomIndex);
        }
    }

    void ShufflePositions()
    {
        ///*
        for (int i = 0; i < originalPositions.Length; i++)
        {
            dragPositions[i] = originalPositions[i];
        }
        Debug.LogFormat("Drag Positions:\n\t{0} | {1} | {2}\n\t{3} | {4} | {5}\n\t{6} | {7} | {8}", dragPositions[0], dragPositions[1], dragPositions[2],
            dragPositions[3], originalPositions[4], dragPositions[5],
            dragPositions[6], dragPositions[7], dragPositions[8]);

        // Embaralha as posições dos objetos
        for (int i = 0; i < gameObjects.Length; i++)
        {
            int randomIndex = i;

            do
            {
                randomIndex = Random.Range(0, 9);
            } while (dragPositions[i] == originalPositions[randomIndex]);

            // Troca as posições no array de arrasto
            Vector3 tempPosition = dragPositions[i];
            dragPositions[i] = dragPositions[randomIndex];
            dragPositions[randomIndex] = tempPosition;

            // Atualiza as posições dos objetos
            gameObjects[i].transform.position = dragPositions[i];
            gameObjects[randomIndex].transform.position = dragPositions[randomIndex];

            Debug.LogFormat("Drag Positions ({9}, {10}):\n\t{0} | {1} | {2}\n\t{3} | {4} | {5}\n\t{6} | {7} | {8}", dragPositions[0], dragPositions[1], dragPositions[2],
                dragPositions[3], dragPositions[4], dragPositions[5],
                dragPositions[6], dragPositions[7], dragPositions[8], i, randomIndex);
        }
    }

    bool CheckLevelCompletion()
    {
        for (int i = 0; i < numObj; i++)
        {
            // Verifica se algum objeto não está na posição original
            if (originalPositions[i] != dragPositions[i])
            {
                return false;
            }
        }

        return true;
    }

    public void HandleObjectPlacement(GameObject draggedObject, GameObject targetObject)
    {
        // Obtém os índices dos objetos no array
        int draggedObjIndex = System.Array.IndexOf(gameObjects, draggedObject);
        int targetObjIndex = System.Array.IndexOf(gameObjects, targetObject);
        Debug.LogFormat("Dragged: {0}, Target:{1}", draggedObjIndex, targetObjIndex);

        // Verifica se o componente de renderização está desativado no objeto arrastado ou no objeto alvo
        Renderer draggedRenderer = draggedObject.GetComponent<Renderer>();
        Renderer targetRenderer = targetObject.GetComponent<Renderer>();

        if (draggedRenderer.enabled || targetRenderer.enabled)
        {
            bool bothWrong = true;

            // Troca as posições no array de arrasto
            Vector3 tempPosition = dragPositions[draggedObjIndex];
            dragPositions[draggedObjIndex] = dragPositions[targetObjIndex];
            dragPositions[targetObjIndex] = tempPosition;

            // Atualiza as posições dos objetos
            draggedObject.transform.position = dragPositions[draggedObjIndex];
            targetObject.transform.position = dragPositions[targetObjIndex];

            // Verifica se o objeto alvo
            if (dragPositions[targetObjIndex] == originalPositions[targetObjIndex])
            {
                if (targetRenderer.enabled)
                {
                    AddPointsOnCorrectPlacement();
                    targetObject.GetComponent<Collider2D>().enabled = false;
                    ActiveShine(targetObject);
                    bothWrong = false;
                    Debug.Log("Primeiro");
                }
            }
            // Verifica se o objeto arrastado está na posição correta
            if (dragPositions[draggedObjIndex] == originalPositions[draggedObjIndex])
            {
                if (draggedRenderer.enabled)
                {
                    AddPointsOnCorrectPlacement();
                    draggedObject.GetComponent<Collider2D>().enabled = false;
                    ActiveShine(draggedObject);
                    bothWrong = false;
                    Debug.Log("Segundo");
                }
            }
            if (bothWrong)
            {
                // Subtrai pontos quando o objeto está na posição errada
                SubtractPointsOnIncorrectPlacement();
                Debug.Log("Terceriro");
            }
        }
    }

    public void ActiveShine(GameObject draggedObject)
    {
        // Verifica se o componente de renderização está desativado no objeto arrastado ou no objeto alvo
        Renderer draggedRenderer = draggedObject.GetComponent<Renderer>();

        Transform childTransform = draggedObject.transform.Find("Brilho");
        if (childTransform != null && draggedRenderer.enabled)
        {
            // Agora você pode acessar o objeto filho
            GameObject childObject = childTransform.gameObject;

            // Ative o objeto filho e a animação
            childObject.SetActive(true);

            for (int i = 0; i < Brilhos.Length; i++)
            {
                Brilhos[i].SetBool("isShine", true);
            }
        }
    }

    public Vector3[] GetDragPositions()
    {
        return dragPositions;
    }

    public void AddPointsOnCorrectPlacement()
    {
        // Adiciona pontos e reproduz um som quando o objeto é colocado corretamente
        score += correctPlacementPoints;
        somClicarAcertou.Play();
        estrelas1.SetActive(true);
    }

    public void SubtractPointsOnIncorrectPlacement()
    {
        // Subtrai pontos e reproduz um som quando o objeto é colocado incorretamente
        somClicarErrou.Play();
        fadeRed.SetBool("Damage", true);

        if (score >= Mathf.Abs(incorrectPlacementPoints))
        {
            score += incorrectPlacementPoints;
        }
        else
        {
            score = 0;
        }
    }
}
