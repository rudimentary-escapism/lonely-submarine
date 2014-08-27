﻿using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	private GameObject mainCamera;
	private int destroyDistance = -15;
	private float speed = 0.3f;
	private SubmarineControl submarine;
	private bool sailedSubmarine = false;
	private int submarinePosition = -2;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
		submarine = GameObject.Find ("submarine_limbov3.5").GetComponent<SubmarineControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance)
			Destroy (this.gameObject);

		if (transform.position.x < submarinePosition && !sailedSubmarine) {
			sailedSubmarine = true;
			submarine.AddScore();
		}

		if (!submarine.isEndGame())
			transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
	}
}
