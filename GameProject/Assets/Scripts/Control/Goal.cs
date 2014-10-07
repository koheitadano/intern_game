using UnityEngine;
using System.Collections;
using System;

public class Goal : MonoBehaviour
{
	public event Action OnEnter = null;

	void OnCollisionEnter()
	{
		if (OnEnter != null)
		{
			Debug.Log ("Goal");
			OnEnter();
		}
	}
}