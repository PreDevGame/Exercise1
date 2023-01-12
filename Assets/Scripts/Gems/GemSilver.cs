using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 200;
        //scoreBox.GetComponent<Text>().text = "1000"; // When Player
        //collectSound.Play(); // When Player collect a gem this sound will play
        Destroy(gameObject);
    }
}