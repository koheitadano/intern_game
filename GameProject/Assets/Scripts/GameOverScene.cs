using UnityEngine;
using System.Collections;

public class GameOverScene : MonoBehaviour
{
	private int _screenWidth = Screen.width;
	private int _screenHeight = Screen.height;
	
	[SerializeField]
	CommonButton ReturnTitle = null;
	
	void Start()
	{
		ReturnTitle.OnClick += OnClickSceneTransition;
	}
	
	void OnClickSceneTransition()
	{
		Debug.Log ("Go Title");
		Application.LoadLevel("title");
	}
}
