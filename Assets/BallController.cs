using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public AnimationController AnimationController;
    public Rigidbody Ball;
    public GameObject Cube;
    public Vector3 strikeZone;
    public Vector3 catcherPos;
    public Vector3 ballPos;
    public Vector3 CameraPosition;
    public float power;
    public StrikeController StrikeController;
    public Vector3 HomeRun1;
    public Vector3 Homerun2;
    public Vector3 Homerun3;
    public Vector3 Homerun4;
    public Vector3 Homerun5;
    public Vector3 Homerun6;
    public Vector3 Homerun7;
    public Vector3 Homerun8;
    public Vector3 HomeRun1Pos;
    public Vector3 Homerun2Pos;
    public Vector3 Homerun3Pos;
    public Vector3 Homerun4Pos;
    public Vector3 Homerun5Pos;
    public Vector3 Homerun6Pos;
    public Vector3 Homerun7Pos;
    public Vector3 Homerun8Pos;
    public Camera MainCamera;
    public Camera CenterCamera;
    public Camera LeftCamera;
    public Camera RightCamera;
    public Camera BallCamera;
    public GameObject ball;
    public Vector3 BallCameraPosition;
    public Vector3 ballPosition;
    public Vector3 diffrence;
    public BallCameraController BallCameraController;
    public ParticleSystem particleSystem;
    public GameObject Fireworks1;
    public GameObject Fireworks2;
    public GameObject Fireworks3;
    public GameObject Fireworks4;
    public GameObject Fireworks5;
    public GameObject Fireworks6;
    public GameObject Fireworks7;
    public GameObject Kim;
    public GameObject FlyingDistance;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 aaa;
    public GameObject AudioSource;
    public GameObject Rabbit1;
    public GameObject Rabbit2;
    public GameObject Rabbit3;
    public GameObject Rabbit4;
    public GameObject Rabbit5;
    public GameObject Rabbit6;
    public GameObject Rabbit7;
    public GameObject Rabbit8;
    public GameObject Rabbit9;
    //public Rigidbody UseGravity;
    // Use this for initialization
    void Start()
    {
        Rabbit1 = GameObject.Find("Rabbit1");
        Rabbit2 = GameObject.Find("Rabbit2");
        Rabbit3 = GameObject.Find("Rabbit3");
        Rabbit4 = GameObject.Find("Rabbit4");
        Rabbit5 = GameObject.Find("Rabbit5");
        Rabbit6 = GameObject.Find("Rabbit6");
        Rabbit7 = GameObject.Find("Rabbit7");
        Rabbit8 = GameObject.Find("Rabbit8");
        Rabbit9 = GameObject.Find("Rabbit9");
        AudioSource = GameObject.Find("AudioSource");
        FlyingDistance = GameObject.Find("FlyingDistance");
        Fireworks1 = GameObject.Find("Fireworks1");
        Fireworks2 = GameObject.Find("Fireworks2");
        Fireworks3 = GameObject.Find("Fireworks3");
        Fireworks4 = GameObject.Find("Fireworks4");
        Fireworks5 = GameObject.Find("Fireworks5");
        Fireworks6 = GameObject.Find("Fireworks6");
        Fireworks7 = GameObject.Find("Fireworks7");
        Kim = GameObject.Find("Kim");
        particleSystem = GetComponent<ParticleSystem>();
        BallCameraController = GetComponent<BallCameraController>();
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        CenterCamera = GameObject.Find("Center Camera").GetComponent<Camera>();
        LeftCamera = GameObject.Find("Left Camera").GetComponent<Camera>();
        RightCamera = GameObject.Find("Right Camera").GetComponent<Camera>();
        BallCamera = GameObject.Find("Ball Camera").GetComponent<Camera>();
        MainCamera.enabled = true;
        CenterCamera.enabled = false;
        LeftCamera.enabled = false;
        RightCamera.enabled = false;
        BallCamera.enabled = false;
        AnimationController = GetComponent<AnimationController>();
        Ball = GetComponent<Rigidbody>();
        Ball.useGravity = false;
        StrikeController = GetComponent<StrikeController>();
        Cube = GameObject.Find("Cube");
        catcherPos = new Vector3(Cube.transform.position.x, Cube.transform.position.y, 0) + new Vector3(Random.Range(-1.5f, 2.5f), Random.Range(-1.5f, 1.5f), 0);
        ballPos = new Vector3(this.Ball.transform.position.x, this.Ball.transform.position.y, -this.Ball.transform.position.z);
        strikeZone = catcherPos - ballPos;
        power = 40.0f;
        BallCameraPosition = new Vector3(BallCamera.transform.position.x, BallCamera.transform.position.y, BallCamera.transform.position.z);
        ballPosition = transform.position;
        diffrence = ballPosition - this.transform.position;

        //Homerun1 = new Vector3(-3.0f, 217.0f, -364.0f);
        //Homerun1Pos = Homerun1 - ballPos;

    }

    // Update is called once per frame
    void Update()
    {
        ballPos = new Vector3(this.Ball.transform.position.x, this.Ball.transform.position.y, -this.Ball.transform.position.z);
        HomeRun1 = new Vector3(-3.0f, 217.0f, -364.0f);
        HomeRun1Pos = HomeRun1 - ballPos;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Ball.transform.position.z >= 129.0f && Ball.transform.position.z < 131.0f)
            {
                Invoke("FlyingBall", 0.6f);

            }
            else if (Ball.transform.position.z >= 115.0f && Ball.transform.position.z < 119.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z >= 119.0f && Ball.transform.position.z < 123.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z >= 123.0f && Ball.transform.position.z < 127.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z >= 127.0f && Ball.transform.position.z < 129.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z > 129.0f && Ball.transform.position.z < 133.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z >= 133.0f && Ball.transform.position.z < 137.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }
            else if (Ball.transform.position.z >= 137.0f && Ball.transform.position.z < 141.0f)
            {
                Invoke("FlyingBall", 0.6f);
            }

            //if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)){
            //GameObject ball = Instantiate(ballPrefab) as GameObject;
            //ball.transform.position = new Vector3(2.05f, 43.69f, 82.54f);
            //}
            //this.transform.Rotate(new Vector3(0, 0, 360));
            //Ball.AddForce(strikeZone * power, ForceMode.Force);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "catcher")
        {
            Debug.Log("消えました");
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "HomeRun1")
        {
            Destroy(this.gameObject);
            Fireworks1.GetComponent<ParticleSystem>().Play();
            Fireworks2.GetComponent<ParticleSystem>().Play();
            Fireworks3.GetComponent<ParticleSystem>().Play();
            Fireworks4.GetComponent<ParticleSystem>().Play();
            Fireworks5.GetComponent<ParticleSystem>().Play();
            Fireworks6.GetComponent<ParticleSystem>().Play();
            Fireworks7.GetComponent<ParticleSystem>().Play();
            MainCamera.enabled = false;
            CenterCamera.enabled = false;
            BallCamera.enabled = true;
            Kim.transform.position = new Vector3(16.92f, 37.35f, 94.16f);
            Rabbit1.transform.position = new Vector3(-6.55f, 40.99f, 57.36f);
            Rabbit2.transform.position = new Vector3(20f, 41.11f, 57.36f);
            Rabbit3.transform.position = new Vector3(33.18f, 41.11f, 57.36f);
            Rabbit4.transform.position = new Vector3(7.48f, 41.11f, 57.36f);
            Rabbit5.transform.position = new Vector3(-19.35f, 41.11f, 57.36f);
            Rabbit6.transform.position = new Vector3(-34.18f, 41.11f, 57.36f);
            Rabbit7.transform.position = new Vector3(-28.68f, 41.11f, -96.32f);
            Rabbit8.transform.position = new Vector3(-31.53f, 41.11f, -103.54f);
            Rabbit9.transform.position = new Vector3(3.99f, 46.91f, -103.54f);
            Invoke("KimRotate", 1.0f);
            AudioSource.GetComponent<AudioController>().BatterHittingCool();
            pos1 = new Vector3(4.4f, 40.0f, 144.0f);
            pos2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            FlyingDistance.GetComponent<Text>().text = (pos2 - pos1).magnitude - 468 + " m";
        }
        else if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            Kim.transform.position = new Vector3(16.92f, -100f, 94.16f);
            Rabbit1.transform.position = new Vector3(-6.55f, -100f, 57.36f);
            Rabbit2.transform.position = new Vector3(20f, -100f, 57.36f);
            Rabbit3.transform.position = new Vector3(33.18f, -100f, 57.36f);
            Rabbit4.transform.position = new Vector3(7.48f, -100f, 57.36f);
            Rabbit5.transform.position = new Vector3(-19.35f, -100f, 57.36f);
            Rabbit6.transform.position = new Vector3(-34.18f, -100f, 57.36f);
            Rabbit7.transform.position = new Vector3(-28.68f, -100f, -96.32f);
            Rabbit8.transform.position = new Vector3(-31.53f, -100f, -103.54f);
            Rabbit9.transform.position = new Vector3(3.99f, -100f, -103.54f);
            Fireworks1.GetComponent<ParticleSystem>().Stop();
            Fireworks2.GetComponent<ParticleSystem>().Stop();
            Fireworks3.GetComponent<ParticleSystem>().Stop();
            Fireworks4.GetComponent<ParticleSystem>().Stop();
            Fireworks5.GetComponent<ParticleSystem>().Stop();
            Fireworks6.GetComponent<ParticleSystem>().Stop();
            Fireworks7.GetComponent<ParticleSystem>().Stop();

        }
   }

    
//void OnBecameInvisible()
	//{
		//Destroy(this.gameObject);
	//}

    public void throwBall()
    {
        Ball.AddForce(strikeZone * power, ForceMode.Force);
    }
    public void FlyingBall()
    {
        Ball.velocity = Vector3.zero;
        Ball.AddForce(HomeRun1Pos * power, ForceMode.Force);
        MainCamera.enabled = false;
        CenterCamera.enabled = true;
        //BallCameraController.enabled = true;
        //BallCameraPosition = diffrence;
        //CenterCamera.enabled = true;
        Ball.useGravity = true;

    }
    public void KimRotate(){
        //Kim.GetComponent<Rigidbody>().transform.rotation = Quaternion.Euler(2.522f, -9.842f, 0.036f);
    }

}
    