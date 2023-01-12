using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectTotalLevel.redirectTolLevel = 3;
        StartCoroutine(fadeInOff());
    }

    IEnumerator fadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

}
