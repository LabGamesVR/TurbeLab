using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarF2M3 : MonoBehaviour
{
    public GameObject dedoInstrucao, fade2, fade, contagem, pauseMenu;
    public GameObject[] enemyHorizontal, enemyVertical;

    // Start is called before the first frame update
    void Start()
    {
        StartPhase();
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem.activeSelf==true || pauseMenu.activeSelf==true || fade.activeSelf==true || fade2.activeSelf==true) {
            ColliderDrag.velocity = 0;
            enemyHorizontal[0].GetComponent<EnemyHorizontal>().enabled=false;
            enemyHorizontal[1].GetComponent<EnemyHorizontal>().enabled=false;
            enemyHorizontal[2].GetComponent<EnemyHorizontal>().enabled=false;
            enemyVertical[0].GetComponent<EnemyVertical>().enabled=false;
            enemyVertical[1].GetComponent<EnemyVertical>().enabled=false;
            enemyVertical[2].GetComponent<EnemyVertical>().enabled=false;
            enemyVertical[3].GetComponent<EnemyVertical>().enabled=false;
        } else {
            ColliderDrag.velocity = 25;
            enemyHorizontal[0].GetComponent<EnemyHorizontal>().enabled=true;
            enemyHorizontal[1].GetComponent<EnemyHorizontal>().enabled=true;
            enemyHorizontal[2].GetComponent<EnemyHorizontal>().enabled=true;
            enemyVertical[0].GetComponent<EnemyVertical>().enabled=true;
            enemyVertical[1].GetComponent<EnemyVertical>().enabled=true;
            enemyVertical[2].GetComponent<EnemyVertical>().enabled=true;
            enemyVertical[3].GetComponent<EnemyVertical>().enabled=true;
        }
    }

    void StartPhase() {
        StartCoroutine("FadeStart");
    }

    IEnumerator FadeStart() {
        yield return new WaitForSeconds(2f);
        fade2.SetActive(false);
        contagem.SetActive(true);
        yield return new WaitForSeconds(2f);
        dedoInstrucao.SetActive(true);
    }

}
