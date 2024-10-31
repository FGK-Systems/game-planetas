using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneGameOverManager : MonoBehaviour
{

    public TextMeshProUGUI statusGameText;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        scoreText.text = "Pontuação: " + GameManager.score;
        if(GameManager.statusGame == "Win"){
            statusGameText.text = "ÓTIMO, VOCÊ VENCEU!";
        }else{
            statusGameText.text = "Quase lá, na próxima você consegue!";
        }
    }

    public void GoToMenu(){
        SceneManager.LoadScene(0);
    }

    
}
