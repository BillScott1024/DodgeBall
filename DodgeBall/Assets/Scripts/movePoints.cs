using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoints : MonoBehaviour {

    // Use this for initialization

    public static Transform[] positions;

    // Use this for initialization
    void Awake()
    {
        positions = new Transform[transform.childCount];
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = transform.GetChild(i);
        }

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
