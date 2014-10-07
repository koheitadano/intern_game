using UnityEngine;
using System.Collections;

public class ResultScene : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private int _screenWidth = Screen.width;
	private int _screenHeight = Screen.height;
	private GUISkin _skin;
	private string _scoreText;

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


	void OnGUI()
	{
		GUI.skin = _skin;
//		GUI.Label(Rect(0, _screenHeight/4, _screenWidth, _screenHeight/4), _scoreText, "message");
	}
	//====================
	// Property
	//====================

}
