using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour {

    public GameObject shootingPosition;
    public Rigidbody ball;
    public float power = 600f;
    public Vector3 towards = new Vector3(0, 0.1f, 1);
    // Use this for initialization
    void Start () {

        InvokeRepeating("shootingBalls", 2f, 1f);

    }
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetButtonUp("Fire1")) {
        //    Rigidbody instance = Instantiate(ball, transform.position, transform.rotation) as Rigidbody;

        //    Vector3 fwd = transform.TransformDirection(towards);
           
        //    instance.AddForce(fwd * power);

        //}
	}

    void shootingBalls() {
        Rigidbody instance = Instantiate(ball, transform.position, transform.rotation) as Rigidbody;

        Vector3 fwd = transform.TransformDirection(towards);

        instance.AddForce(fwd * power);
    }
}
