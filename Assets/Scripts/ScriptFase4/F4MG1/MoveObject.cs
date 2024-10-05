using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    private GameController gameController; // Refer�ncia ao GameController

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        if (isDragging)
        {
            // Mover o objeto com base na posi��o do mouse ou do toque
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

    private void OnMouseDown()
    {
        // Iniciar o arrastar do objeto
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Defina o Order in Layer para -2 enquanto est� sendo arrastado
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sortingOrder = -2;
        }

        // Desative o collider enquanto estiver arrastando
        Collider2D collider = GetComponent<Collider2D>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }

    private void OnMouseUp()
    {
        // Parar o arrastar do objeto
        isDragging = false;

        // Defina o Order in Layer de volta para -3 quando o objeto for solto
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sortingOrder = -3;
        }

        // Ative o collider quando o objeto for solto
        Collider2D collider = GetComponent<Collider2D>();
        if (collider != null)
        {
            collider.enabled = true;
        }

        // Crie um Collider2D tempor�rio para representar o objeto arrastado
        Collider2D tempCollider = gameObject.AddComponent<BoxCollider2D>();

        // Verifique a sobreposi��o de colliders para determinar se o objeto est� na �rea correta
        Collider2D[] overlappedColliders = new Collider2D[10]; // Ajuste o tamanho conforme necess�rio
        ContactFilter2D contactFilter = new ContactFilter2D();
        contactFilter.useTriggers = false; // Certifique-se de que colis�es reais sejam consideradas

        int numOverlaps = tempCollider.OverlapCollider(contactFilter, overlappedColliders);

        bool overlapped = false;

        for (int i = 0; i < numOverlaps; i++)
        {
            GameObject overlappedObject = overlappedColliders[i].gameObject;
            if (overlappedObject != gameObject) // Certifique-se de n�o comparar com ele mesmo
            {
                overlapped = true;
                gameController.HandleObjectPlacement(gameObject, overlappedObject);
                break; // Pare a verifica��o ap�s encontrar um objeto sobreposto
            }
        }

        // Remova o Collider2D tempor�rio
        Destroy(tempCollider);

        // Se n�o houver sobreposi��o com outro objeto, volte � posi��o que estava
        if (!overlapped)
        {
            transform.position = gameController.GetDragPositions()[System.Array.IndexOf(gameController.gameObjects, gameObject)];
        }
    }

}
