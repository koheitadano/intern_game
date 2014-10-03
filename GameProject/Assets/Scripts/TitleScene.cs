using UnityEngine;
using System.Collections;

public class TitleScene : MonoBehaviour {

	//====================
	// PrivateMember
	//====================

	//====================
	// SerializeFieldMember
	//====================
	[SerializeField]
	CommonButton PushStart = null;

	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
		PushStart.OnClick += OnClickSceneTransition;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnClickSceneTransition()
	{
		// ButtonClick	
		Debug.Log ("Go Game");
		Application.LoadLevel("game");
	}

	//====================
	// Property
	//====================

}
