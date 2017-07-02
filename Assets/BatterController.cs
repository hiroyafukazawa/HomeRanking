using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterController : MonoBehaviour {
    public StrikeController StrikeController;
    public AnimationController AnimationController;
    public GameObject Pitcher;
    public Animation shoot01;
    GameObject cube;
    BallController BallController;
    public GameObject AudioSource;
    public GameObject BallCamera;
    public GameObject ball;
    //public Vector3 difference;
    public Vector3 BallCameraPos;
    public Vector3 ballPos;
    //public PitcherController PitcherController;

    // Use this for initialization
	void Start () {
        
        AnimationController = GetComponent<AnimationController>();
        cube = GameObject.Find("Cube");
        StrikeController = cube.GetComponent<StrikeController>();
        AudioSource = GameObject.Find("AudioSource");
        //PitcherController = GetComponent<PitcherController>();
    }

    // Update is called once per frame
    void Update(){
        ball = GameObject.Find("ball");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (StrikeController.isStrikeZone == true)
            {
                AnimationController.anim.Play("hit01");
            }
            else
            {
                AnimationController.anim.Play("fail01");
                AudioSource.GetComponent<AudioController>().BatterSwingAwayCool();
            }
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
           AnimationController.anim.Play("Take 001");
        }
    }
    public void batterBigHitting(){
        AudioSource.GetComponent<AudioController>().BatterBigHitting();
    }
	public void batterSwingAway()
	{
        AudioSource.GetComponent<AudioController>().BatterSwingAway();
	}
    public void BallCameraView(){
        BallCamera = GameObject.Find("Ball Camera");
        ball = GameObject.Find("ball");
        float difference = BallCamera.transform.position.z - ball.transform.position.z;
        BallCamera.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z - difference);
    }
}
