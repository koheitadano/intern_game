using UnityEngine;
using System;
using System.Collections;

public class JumpFloor : MonoBehaviour
{
	public event Action OnEnter = null;

	void OnCollisionEnter()
	{
		Debug.Log ("Jump");
		// Playerのstateを切り替える
		if (OnEnter != null)
		{
			OnEnter();
		}
	}
}
