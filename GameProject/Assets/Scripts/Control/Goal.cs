using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private bool _goalFlag = false;
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
		if (_goalFlag == true)
		{
			_goalCounter++;
		}

		if (_goalCounter > 10)
		{
			_goalCounter = 0;
			_goalFlag = false;
			Application.LoadLevel("result");
		}
	}

	void OnCollisionEnter()
	{
		Debug.Log ("Goal");
		_goalFlag = true;
	}
}