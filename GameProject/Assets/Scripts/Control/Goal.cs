using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private int _goalCounter = 0;

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
		// ここ途中!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//		if(  == true)
		_goalCounter++;
		if (_goalCounter > 10)
		{
			_goalCounter = 0;
			Application.LoadLevel("result");
		}
	}

	void OnCollisionEnter()
	{
	}
}