using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    //dados da classe
    public static int score;
    public static string statusGame;
    public static float timer; //tempo de jogo

    //dados do objeto
    //recursos UI
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    //perguntas e targets
    public List<string> questions;
    public List<GameObject> imageTargets;


     
    private int index; //index da pergunta que estou respondendo
    private int qtdQuestions; //quantas questões tenho no jogo

    private IEnumerator coroutine;
    
    void Start() {
        StartGame();
    }

    private void StartGame(){
        index = -1; //Sinaliza que não há perguntas ainda
        qtdQuestions = imageTargets.Count -1; //define a ultima posição valida da lista de perguntas
        score = 0; //zera apontuação 
        timer = 120f; //Define tempo
        statusGame = "Play";
        coroutine = WaitTimer();
        StartCoroutine(coroutine);
        ShowQuestion();
    }
    public void ShowQuestion(){
        index++;
        if(index <=qtdQuestions){
            questionText.text = questions[index];
            Instantiate(imageTargets[index]);
        }else{
            statusGame = "Win";
            SceneManager.LoadScene(2);
        }
    }
    private void ShowHud(){
        scoreText.text = "PONTUAÇÃO: " + score;
        timerText.text = "TEMPO: " + (int)timer;
    }

    private IEnumerator WaitTimer(){
        while(statusGame == "Play"){
            yield return new WaitForSeconds(1f);
            timer -= 1f;
            ShowHud(); //exibir dados na tela

            if(timer <= 0) statusGame = "GameOver";
        }
        SceneManager.LoadScene(2);
    }

}
