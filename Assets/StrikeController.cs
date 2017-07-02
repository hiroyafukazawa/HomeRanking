using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeController : MonoBehaviour {
    public bool isStrikeZone;
    public Vector3 BallPosition;
    public GameObject ball;
    // Use this for initialization
	void Start () {
        ball = GameObject.Find("ball");  	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //ストライクゾーンに入った瞬間
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            isStrikeZone = true;
            ball = other.gameObject;
        }
           
    }
	//ストライクゾーンから出た瞬間
	public void OnTriggerExit(Collider other)
    {
		if (other.gameObject.tag == "Ball")
		{
            isStrikeZone = false;
		}
    }
	//ストライクゾーンの中
	public void OnTriggerStay(Collider other)
    {
		if (other.gameObject.tag == "Ball")
		{
            isStrikeZone = true;
		}
    }
}
