using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour {

    public GameObject scoreLabel;
    public GameObject gameLevelLabel;
    //public GameObject nextGameButton;
	// Use this for initialization
	void Start ()
    {
        gameLevelLabel.GetComponent<Text>().text = "关卡：第一关";

        


        showGameLevel();
	}

    public void showGameLevel()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "MainScene":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第一关";
                break;
            case "Level_2":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第二关";
                break;
            case "Level_3":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第三关";
                break;
            case "Level_4":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第四关";
                break;
            case "Level_5":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第五关";
                break;
            case "Level_6":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第六关";
                break;
            default:
                Debug.Log("onload SceneName error");
                break;
        }
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
