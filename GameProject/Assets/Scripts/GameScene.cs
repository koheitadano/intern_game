﻿using UnityEngine;
using System.Collections;

public class GameScene : MonoBehaviour
{

	//====================
	// PrivateMember
	//====================

	//====================
	// SerializeFieldMember
	//====================
	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}


	void OnCollisionEnter()
	{
		Debug.Log ("GameOver");
		Application.LoadLevel("result");
	}

	//====================
	// Property
	//====================

}
