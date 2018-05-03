using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject titleText;
    public GameObject startGameText;

    public GameObject levelGroup1;
    public GameObject levelGroup2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStartGame()
    {
        titleText.GetComponent<Animation>().Play("Title_Move_Out");
        startGameText.GetComponent<Animation>().Play("StartButton_Move_Out");
        Invoke("showLevel",1.0f);
      
    }

    public void showLevel()
    {
        // Application.LoadLevel("MainScene");
        levelGroup1.GetComponent<Animation>().Play("Level_Move_Down");
        levelGroup2.GetComponent<Animation>().Play("Level_Move_Up");
    }

    public void loadLevel1()
    {
        Application.LoadLevel("MainScene");
    }

    public void loadLevel2()
    {
        Application.LoadLevel("Level1");
    }
}
