using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;
    public AudioClip audioClip6;
    //public AudioClip audioClip7;
    //public AudioClip audioClip8;
    //public AudioClip audioClip9;
    //public AudioClip audioClip10;
    //public AudioClip audioClip11;
    //public AudioClip audioClip12;
    //public AudioClip audioClip13;
     public AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PitcherThrowing(){
        this.audioSource.clip = this.audioClip1;
        this.audioSource.Play();
        audioSource.loop = false;
    }
    public void BatterBigHitting(){
		this.audioSource.clip = this.audioClip2;
		this.audioSource.Play();
		audioSource.loop = false;
    }
	public void BatterSwingAway()
	{
		this.audioSource.clip = this.audioClip3;
		this.audioSource.Play();
		audioSource.loop = false;
	}
	public void BatterSwingAwayCool()
	{
		this.audioSource.clip = this.audioClip5;
		this.audioSource.Play();
		audioSource.loop = false;
	}
	public void BatterHittingCool()
	{
		this.audioSource.clip = this.audioClip4;
		this.audioSource.Play();
		audioSource.loop = false;
	}
}
