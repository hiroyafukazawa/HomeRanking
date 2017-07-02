using UnityEngine;
using System.Collections;

public class HitPlayer : MonoBehaviour {

	public GUIText m_HelpText=null;

	public GameObject m_HitPlayer=null;
	
	bool bEnd=true;

	// Use this for initialization
	void Start () {
		//m_HelpText.text=m_HelpText.text.Replace("\\","\n");
		m_HitPlayer.GetComponent<Animation>()["idle"].wrapMode=WrapMode.Loop;
		m_HitPlayer.GetComponent<Animation>().Play("idle");
	}
	
	// Update is called once per frame
	void Update () {
		if (bEnd) {
			if (Input.GetKeyDown(KeyCode.B)) {
				bEnd=false;
				StartCoroutine("PlayAni","hit");
				return;
			}
			if (Input.GetKeyDown(KeyCode.C)) {
				bEnd=false;
				StartCoroutine("PlayAni","fail");
			}
		}
	}
	
	IEnumerator PlayAni(string name) {
		m_HitPlayer.GetComponent<Animation>().Play(name);
		yield return new WaitForSeconds(m_HitPlayer.GetComponent<Animation>()[name].length);
		m_HitPlayer.GetComponent<Animation>().Play("idle");
		bEnd=true;
	}
}
