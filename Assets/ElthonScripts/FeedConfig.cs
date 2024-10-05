using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedConfig : MonoBehaviour
{
    [SerializeField] GameObject check;

    public static int feedCount = 1;

    private void Update()
    {
        if (feedCount > 0)
        {
            check.SetActive(true);
        }
        else
        {
            check.SetActive(false);
        }
    }

    public void DeactiveFeed()
    {
        feedCount *= -1;

        if(feedCount > 0)
        {
            check.SetActive(true);
        }
        else
        {
            check.SetActive(false);
        }
    }
}
