using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Change scenes when the user presses the start button
public class ChangeScene : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("Cover_Scene");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }
}
