using UnityEngine;
using System.Collections;

public class ResultScene : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	
	//====================
	// SerializeFieldMember
	//====================
	[SerializeField]
	CommonButton ReturnTitle = null;
	
	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
		ReturnTitle.OnClick += OnClickSceneTransition;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnClickSceneTransition()
	{
		// ButtonClick	
		Debug.Log ("Go Title");
		Application.LoadLevel("title");
	}

	//====================
	// Property
	//====================

}
