using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime + 14400;

		string hours = ((int)t / 1200).ToString ();
		string minutes = (((int)t / 60)%12).ToString ();
		string seconds = (t % 60).ToString ("f0");

		timerText.text = hours + ":" + minutes + ":" + seconds;
	}
}
