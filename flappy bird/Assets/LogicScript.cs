using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public float Speed=5;
    public int Score;
    public Text ScoreText;
    public GameObject GameOverScreen;


    public void addScore(int add){
        Score += add;
        ScoreText.text= Score.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        GameOverScreen.SetActive(true);
    }
    public float getSpeed(){
        if(Speed>=16){

        }
        else{
            Speed=Speed+1;
        }
        return Speed;
    }
    public void Exit(){
        Application.Quit();
    }
    
}
