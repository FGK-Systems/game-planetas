using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public void GoNextQuestion(){
        GameManager.score += 50;
        GameManager.timer +=10f;// O JOGADOR GANHA MAIS 5 SEGUNDOS AO ACERTAR
        Invoke("NextQuestion", 10f);
    }
    private void NextQuestion(){    
        GameObject.Find("GameManager").GetComponent<GameManager>().ShowQuestion();
        Destroy(gameObject);
    }
}
