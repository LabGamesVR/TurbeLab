using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideImage : MonoBehaviour
{
    public GameObject image;
    public float showDuration;
    private bool imageActive = false;

    void Start()
    {
        StartCoroutine(ShowImage());
    }

    IEnumerator ShowImage()
    {
        image.SetActive(true);
        imageActive = true;
        yield return new WaitForSeconds(showDuration);
        imageActive = false;
        image.SetActive(false);
    }

    void Update()
    {
        if (imageActive)
        {
            imageActive = false;
            image.SetActive(false);
        }
    }
}
