﻿using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("r")){
			Debug.Log ("R is pressed.");
		}
	}
}
