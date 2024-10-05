using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinhaScript : MonoBehaviour 
{
    public float minValue, maxValue;
    public static float tempoChange = 5f;
    public int vezes;
    public float changeTime;

    void Start() {
        StartCoroutine("RandomLine");
    }

    void Update() {
        changeTime = tempoChange;
    }

    private void Randomize(){
        float rand = Random.Range(minValue, maxValue);
        transform.localScale = new Vector3(0.1f, rand, 0);
    }

    IEnumerator RandomLine() {
        yield return new WaitForSeconds(6f);
        for(int i=0; i<vezes; i++) {
            yield return new WaitForSeconds(tempoChange);
            Randomize();
        }
    }

}
