using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCameraController : MonoBehaviour
{

    public GameObject ball;
    public float differenceX;
    public float differenceY;
    public float differenceZ;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        differenceX = ball.transform.position.x - transform.position.x;
        differenceY = ball.transform.position.y - transform.position.y;
        differenceZ = ball.transform.position.z - transform.position.z;
        this.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z - differenceZ);
        Debug.Log(ball.transform.position);
	}
}

