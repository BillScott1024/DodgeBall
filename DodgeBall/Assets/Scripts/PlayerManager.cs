using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public float moveSpeed = 5f;
    public int healthCount = 3;
    public GameObject gameManager;
    public GameObject audioManager;
    public GameObject[] healthImages;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(h, 0, 0);
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("发生碰撞:" + other.gameObject.name);
        healthCount--;
        for (int i = 2; i >= 0; i--)
        {
            if (healthImages[i].activeInHierarchy == true)
            {
                healthImages[i].SetActive(false);
                break;
            }
            
        }
       
        if (healthCount <= 0)
        {
            gameManager.GetComponent<ScenesManager>().OnGameOver();
            audioManager.GetComponent<AudioManager>().playFailedAudio();
        }
    }
}
