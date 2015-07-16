﻿using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	public float moveSpeed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.A))
		{
			transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime,
			                                 transform.position.y,
			                                 transform.position.z);
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime,
			                                 transform.position.y,
			                                 transform.position.z);
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			transform.position = new Vector3(transform.position.x,
			                                 transform.position.y,
			                                 transform.position.z - moveSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.position = new Vector3(transform.position.x,
			                                 transform.position.y,
			                                 transform.position.z + moveSpeed * Time.deltaTime);
		}

	}
}
