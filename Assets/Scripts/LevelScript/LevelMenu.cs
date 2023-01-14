using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    public void Level_1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level_2()
    {
        SceneManager.LoadScene(4);
    }
}
