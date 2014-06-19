﻿using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	private GameObject mainCamera;
	private int destroyDistance = -15;
	private float speed = 0.2f;
	private SubmarineControl submarine;
	private Scene scene;
	private bool sailedSubmarine = false;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
		submarine = GameObject.Find ("submarine_limbov3.5").GetComponent<SubmarineControl>();
		scene = mainCamera.GetComponent<Scene>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance)
			Destroy (this.gameObject);

		if (transform.position.x < -2 && transform.position.y < scene.GetBottomBorderOfUpperMine() && !sailedSubmarine) {
			sailedSubmarine = true;
			submarine.AddScore();
		}
		
		transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
	}
}
