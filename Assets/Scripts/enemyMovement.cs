﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime *0.3f);
		transform.LookAt(Camera.main.transform.position);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
	}
}
