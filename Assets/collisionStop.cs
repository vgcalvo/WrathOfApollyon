﻿using UnityEngine;
using System.Collections;

public class collisionStop : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Baker_house") {
			Debug.Log ("collided");
			//ContactPoint contact = collision.contacts [0];
			//Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
			//Vector3 pos = contact.point;
		}
     } 
}