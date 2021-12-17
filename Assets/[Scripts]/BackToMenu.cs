using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public static bool inStartScene = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            LoadMenu();
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void checkForPaused()
    {
        Time.timeScale = 1f;
    }

}
