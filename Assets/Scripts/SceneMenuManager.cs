using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuManeger : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void Planetas(){
        SceneManager.LoadScene(3);
    }

    public void QuitApp(){
        Application.Quit();
    }
}
