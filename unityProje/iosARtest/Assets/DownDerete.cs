﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownDerete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (transform.position.y < -10.0f) {
			Destroy (this.gameObject);
		}
	}
}
