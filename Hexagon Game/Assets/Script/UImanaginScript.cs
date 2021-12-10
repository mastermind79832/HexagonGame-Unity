using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanaginScript : MonoBehaviour
{
   
    public GameObject Title;
    public GameObject startButton;

    public GameObject scoreText;

    public GameObject highScoreText;

    public GameObject Camera;
    public GameObject dropDown;
   
   
   
    // Start is called before the first frame update
    void Start()
    {

        
        Title.SetActive(true);
        startButton.SetActive(true);

        highScoreText.GetComponent<Text>().text = "HighScore : " + ScoreScipt.GetHighScore().ToString();
        scoreText.GetComponent<Text>().text = "Score : " + ScoreScipt.GetScore().ToString();
        scoreText.SetActive(false);
        highScoreText.SetActive(true);
        
    }

    public void SetGameStart()
    {
        if(!GameController.isGameStart && !GameController.isGameOver)
        {
            ScoreScipt.ResetScore();
            GameController.isGameStart = true;
            Title.SetActive(false);
            startButton.SetActive(false);
            scoreText.SetActive(true);
            
            highScoreText.SetActive(false);
        }
        // else if(!GameController.isGameStart && GameController.isGameOver)
        // {

        //     GameController.isGameOver = false ;
        //     Title.SetActive(true);
        //     //SceneManager.LoadScene(0);
        // }
    }

    private void FixedUpdate()
    {
        scoreText.GetComponent<Text>().text = "Score : " + ScoreScipt.GetScore().ToString();
        if(GameController.isGameOver)
        {
            startButton.SetActive(true);
            ScoreScipt.setHighScore();
            highScoreText.GetComponent<Text>().text = "HighScore : " + ScoreScipt.GetHighScore().ToString();
            highScoreText.SetActive(true);
        }
    }

    public void Replay()
    {
        if(GameController.isGameOver)
        {
            scoreText.SetActive(false);
            GameController.isGameStart = false;
            GameController.isGameOver = false ;
            Title.SetActive(true);
            //ScoreScipt.UpdateHighScore();
            
        }
    }


    public void ColourChange()
    {
        int value = dropDown.GetComponent<Dropdown>().value;
        if (value == 1)
            Camera.GetComponent<Camera>().backgroundColor = new Color32(66,188,82,0);
        else if(value == 2)
            Camera.GetComponent<Camera>().backgroundColor = new Color32(66, 139, 188, 0);
        else
            Camera.GetComponent<Camera>().backgroundColor = new Color32(197,57,82,0);
    }

}
