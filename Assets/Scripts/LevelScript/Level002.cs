using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectTotalLevel.redirectTolLevel = 4;
        StartCoroutine(fadeInOff());
    }

    IEnumerator fadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

}
