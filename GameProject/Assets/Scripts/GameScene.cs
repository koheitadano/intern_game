using UnityEngine;
using System.Collections;

public class GameScene : MonoBehaviour
{

	void OnCollisionEnter()
	{
		Debug.Log ("GameOver");
		Application.LoadLevel("gameover");
	}
}
