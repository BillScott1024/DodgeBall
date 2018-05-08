using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{

    public GameObject titleText;
    public GameObject startGameText;

    public GameObject levelGroup1;
    public GameObject levelGroup2;

    public GameObject gameOverUI;
    //public AudioSource gameWinAudio;
    //public AudioSource gameFailedAudio;
    public GameObject audioManager;
    public GameObject shootManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void methodSelectWithID(int ID)
    {
        switch (ID)
        {
            case 1001:
                OnStartGame();
                break;
            case 1002:
                loadLevel1();
                break;
            case 1003:
                loadLevel2();
                break;
            case 1004:

                break;
            default:
                Debug.Log("methodID error");
                break;


        }
    }

    public void OnStartGame()
    {
        titleText.GetComponent<Animation>().Play("Title_Move_Out");
        startGameText.GetComponent<Animation>().Play("StartButton_Move_Out");
        Invoke("showLevel", 1.0f);

    }

    public void OnGameOver()
    {

        Debug.Log("show gameover failed Aniamtion");
        gameOverUI.SetActive(true);

        //  audioManager.GetComponent<AudioManager>().playFailedAudio();
        audioManager.GetComponent<AudioManager>().stopBgmAduio();
        shootManager.GetComponent<ShootingManager>().stopShoot();

    }
    public void showGameWin()
    {
        Debug.Log("show gameover win Aniamtion");
        gameOverUI.SetActive(true);
        //    audioManager.GetComponent<AudioManager>().playWinAudio();
        audioManager.GetComponent<AudioManager>().stopBgmAduio();
        shootManager.GetComponent<ShootingManager>().stopShoot();
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
        Application.LoadLevel("Level2");
    }
}
