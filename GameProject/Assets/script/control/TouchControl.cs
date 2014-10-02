using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour
{

	//====================
	// PrivateMember
	//====================
	private Touch _touch;

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

	//====================
	// Property
	//====================
	public bool GetTouchTrigger ()
	{
		if (Input.touchCount == Constant.TouchNumber)
		{
			if(_touch.phase == TouchPhase.Began)
			{
				print ("Touch == true");
				return true;
			}
			else
			{
				print ("Touch == false");
				return false;
			}
		}
		else
		{
			print ("Touch == non");
			return false;
		}
	}

}
