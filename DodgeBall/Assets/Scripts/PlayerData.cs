using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    private int healthCount = 3;

   // public PlayerData player = new PlayerData();

    // Use this for initialization
    void Start () {
		
	}
    public int initHealth()
    {
        healthCount = 3;
        return healthCount;
    }
    public int getHealth()
    {
        return healthCount;
    }
    public int reduceHealth(int num)
    {
        return healthCount - num;
    }


	// Update is called once per frame
	void Update () {
		
	}
}
