using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour {

	public AudioSource bilboPunch;
	public AudioSource oriStab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X)) {
			oriStab.Play();
		}
		if (Input.GetMouseButtonDown(0)) {
			bilboPunch.Play();
		}
	}
}
