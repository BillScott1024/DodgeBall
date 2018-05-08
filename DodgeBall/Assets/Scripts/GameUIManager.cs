using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour {

    public GameObject scoreLabel;
    public GameObject gameLevelLabel;

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
            case "Level2":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第二关";
                break;
            case "Level3":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第三关";
                break;
            case "Level4":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第四关";
                break;
            case "Level5":
                gameLevelLabel.GetComponent<Text>().text = "关卡：第五关";
                break;
            case "Level6":
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
