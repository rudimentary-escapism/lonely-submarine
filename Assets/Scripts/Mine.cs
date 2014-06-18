﻿using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	private GameObject mainCamera;
	private int destroyDistance = -15;
	private float speed = 0.2f;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance)
			Destroy (this.gameObject);
		transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
	}
}
