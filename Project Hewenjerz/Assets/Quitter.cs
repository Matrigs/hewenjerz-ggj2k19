﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitter : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
		{
			Debug.Log("A key or mouse click has been detected");
			Application.Quit();
		}
	}
}
