using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitcherController : MonoBehaviour
{
    AnimationController AnimationController;
    //BallController BallController;
    public GameObject bal;
    public GameObject ball;
    public float time;
    BallController BallController;
    GameObject Batter;
    GameObject AudioSource;
    // Use this for initialization
    void Start()
    {
        AnimationController = GetComponent<AnimationController>();

        Batter = GameObject.Find("Batter");
        AudioSource = GameObject.Find("AudioSource");
        //BallController = GetComponent<BallController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
			GameObject Ball = Instantiate(ball) as GameObject;
			Ball.transform.position = new Vector3(2.05f, 43.69f, 82.54f);
			Ball.name = ball.name;
            AnimationController.anim.Play("shoot01");
            //time = time + Time.deltaTime;
            //if (time >= 1.5f){
            //ball.GetComponent<BallController>().throwBall();
            //if((Batter.GetComponent<Animation>().Play("hit") || Batter.GetComponent<Animation>().Play("fail")) && (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)))
            //{
               // AnimationController.anim.Stop("shoot01");
           // }
        }
    }

    public void throwball(){
        bal = GameObject.Find("ball");
        bal.GetComponent<BallController>().throwBall();
    }

    public void pitcherThrowing(){
        AudioSource.GetComponent<AudioController>().PitcherThrowing();

    }
}

