using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpinShip : MonoBehaviour {
	public float speed = 50f;
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
