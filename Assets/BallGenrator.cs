using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenrator : MonoBehaviour
{
    public GameObject ball;
    // Use this for initialization
    void Start()
    {
		GameObject Ball = Instantiate(ball) as GameObject;
		Ball.transform.position = new Vector3(2.05f, 43.69f, 82.54f);
		Ball.name = ball.name;
        //GameObject ball = Instantiate(ballPrefab) as GameObject;
        //ball.transform.position = new Vector3(2.05f, 43.69f, 82.54f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            GameObject Ball = Instantiate(ball) as GameObject;
            Ball.transform.position = new Vector3(2.05f, 43.69f, 82.54f);
            Ball.name = ball.name;
        }
    }
}