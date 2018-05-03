using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour {

    public GameObject shootingPosition;
    public Rigidbody ball;
    public float power = 600f;
    
    public float shootMoveSpeed = 0.4f;
    public Vector3 moveDirection = Vector3.left;

    public AudioSource music;
    // Use this for initialization
    //void Awake()
    //{
    //    positions = new Transform[movePosition.childCount];
    //    for (int i = 0; i < 2; i++)
    //    {
    //        positions[i] = movePosition.GetChild(i);
    //    }

    //}

    void Start () {
        //positions = movePoints.positions;
        InvokeRepeating("shootBalls", 2f, 1f);
        //InvokeRepeating("moveShootPosition",2f,1f);

    }

	// Update is called once per frame
	void Update () {
        
        //if (Input.GetButtonUp("Fire1")) {
        //    Rigidbody instance = Instantiate(ball, transform.position, transform.rotation) as Rigidbody;

        //    Vector3 fwd = transform.TransformDirection(towards);

        //    instance.AddForce(fwd * power);

        //}
        
        moveShootPosition();
	}

    //发射球
    void shootBalls() {
        System.Random rd = new System.Random();

        Vector3 towards = new Vector3(0, rd.Next(0, 10) * 0.1f * 0.3f, 1);

        Rigidbody instance = Instantiate(ball, transform.position, transform.rotation) as Rigidbody;

        Vector3 fwd = transform.TransformDirection(towards);
        
        instance.AddForce(fwd * power);

        music.Play();

        Destroy(instance.gameObject,3f);
    }

    //移动发射球的坐标
    void moveShootPosition() {
        //Vector3 c = moveBounds.center;
        //Vector3 s = moveBounds.size;

        //float x = Random.Range(c.x - s.x * 0.5f, c.x - s.x * 0.5f);
        //float y = Random.Range(c.y - s.y * 0.5f, c.y - s.y * 0.5f);
        //float z = Random.Range(c.z - s.z * 0.5f, c.z - s.z * 0.5f);


        //Vector3 point = new Vector3(x, y, z);

        // transform.Translate(point);

        //float letfPosX = -5f;
        //float rightPosX = -2f;

        //if (transform.position.x >= letfPosX)
        //{
        //    float moveLeft = 1 * Time.deltaTime* shootMoveSpeed;
        //    transform.Translate(moveLeft, 0, 0);
        //}
        //else if ( transform.position.x < rightPosX)
        //{
        //    float moveRight = -1 * Time.deltaTime * shootMoveSpeed;
        //    transform.Translate(moveRight, 0, 0);
        //}

        //if (index > positions.Length - 1) return;
        //transform.Translate((positions[index].position - transform.position).normalized * Time.deltaTime * shootMoveSpeed);
        //Debug.Log("positions[index].position:"+positions[index].position);
        //Debug.Log("transform.position:" + transform.position);

        //if (Vector3.Distance(positions[index].position, transform.position) < 0.5f)
        //{
        //    index++;
        //    index = index >= 1 ? 0 : 1;
        //    Debug.Log(index);

        //}
        //if (index > positions.Length - 1)
        //{
        //    ReachDestination();
        //}
        if (moveDirection == Vector3.left && transform.position.x > -2.45f || moveDirection == Vector3.right && transform.position.x < -5.56f)
        {
            moveDirection = -moveDirection;
        }
        transform.Translate( moveDirection * Time.deltaTime * shootMoveSpeed);

        

    }
}
