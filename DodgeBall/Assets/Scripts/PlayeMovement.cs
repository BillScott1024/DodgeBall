using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMovement : MonoBehaviour {

    public float moveSpeed = 5f;
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
    }
}
