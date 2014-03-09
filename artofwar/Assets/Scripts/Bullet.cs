﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ShotHit(GameObject other)
	{
		Debug.Log ("HIT");
		Health yourHealth = other.GetComponent<Health>();
		if (yourHealth)
		{
			yourHealth.Subtract(1);
		}
	}
}
