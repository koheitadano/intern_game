using UnityEngine;
using System;
using System.Collections;

public class JumpFloorEventDispacher : MonoBehaviour
{
	private JumpFloor[] _jumpFloors = {};
	public event Action OnJump = null;

	void Start()
	{
		_jumpFloors = GetComponentsInChildren<JumpFloor>();

		for (int i = 0; i < _jumpFloors.Length; i++)
		{
			_jumpFloors[i].OnEnter += OnJumpFloorEnter;	
		}
	}

	void OnJumpFloorEnter()
	{
		if (OnJump != null)
		{
			OnJump();
		}
	}
}
