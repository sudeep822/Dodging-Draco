using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
	public static GameManager instance;
	bool gameOver= false;
	int score = 0;

	public Text scoreText;
	public GameObject gameOverPanel;

    private void Awake()
   {
   	instance = this;
   }

    

    public void GameOver()
    {
    	gameOver = true;
    	GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning(); // to stop spawning
    	gameOverPanel.SetActive(true) ;

    }

    public void IncrementScore()
    {
    	if(!gameOver)
    	{  
    		score++;
    		scoreText.text = score.ToString();

    		print(score);
    	}
    }

    public void Restart()
    {
    	SceneManager.LoadScene("Game");  //Game= name of the scenes
    }

    public void Menu()
    {
    	SceneManager.LoadScene("MainMenu");  //MainMenu= name of the scenes
    }




}
