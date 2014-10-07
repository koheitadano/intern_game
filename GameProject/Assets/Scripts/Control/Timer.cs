using UnityEngine;
using System.Collections;
using System;

public class Timer : MonoBehaviour {

	private float _waitingTime = 0.0f;
	private float _timer = 0.0f;
	private bool _paused = true;

	private string _minites = "";
	private string _second = "";
	private string _frame = "";
	
	[SerializeField]
	Goal OnEnterGoal = null;
	
	void Start()
	{
		_timer = 0.0f;
		_waitingTime = 60.0f;
		_paused = false;

		OnEnterGoal.OnEnter += OnEnterGoalToResult;
	}
	
	void Update()
	{
		if (_paused)
		{
			return;
		}
		_timer += Time.deltaTime;
		if (_timer >= _waitingTime)
		{
			_timer = 0.0f;
			_paused = true;
		}


		if ((int)Math.Floor(_timer / 60f) < 10)
		{
			_minites = "0" + (int)Math.Floor(_timer / 60f);
		}
		else
		{
			_minites = "" + (int)Math.Floor(_timer / 60f);
		}

		if ((int)Math.Floor(_timer % 60f) < 10)
		{
			_second = "0" + (int)Math.Floor(_timer % 60f);
		}
		else
		{
			_second = "" + (int)Math.Floor(_timer % 60f);
		}

		if ((int)(_timer % 1 * 100) < 10)
		{
			_frame = "0" + (int)(_timer % 1 * 100);
		}
		else
		{
			_frame = "" + (int)(_timer % 1 * 100);
		}

		guiText.text = _minites+":"+_second+":"+_frame;
	}

	void OnEnterGoalToResult()
	{
		Debug.Log("GetScore");
		PlayerPrefs.SetString("minites", _minites);
		PlayerPrefs.SetString("second", _second);
		PlayerPrefs.SetString("frame", _frame);
	}
}
