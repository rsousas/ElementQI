﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickCardScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown(0))
		  //DestroyCard ();
		
	}

	private void DestroyCard(){

		Destroy (this.gameObject);
	}

	void OnMouseDown ()
	{
		Destroy (this.gameObject);
	}
		
}
