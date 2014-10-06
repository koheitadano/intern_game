using UnityEngine;
using System.Collections;
using System;

public class Timer : MonoBehaviour {

	public float _waitingTime = 0.0f;
	public float _timer;
	public bool _paused = true;

	void Start()
	{
		_timer = 0.0f;
		_waitingTime = 60;
		_paused = false;
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
	}

	private void OnGUI()
	{
		GUILayout.BeginVertical(GUILayout.Width(100));
		GUILayout.Box(String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(_timer / 3600f), Math.Floor(_timer / 60f), Math.Floor(_timer % 60f), _timer % 1 * 100), GUILayout.Width(200));
		GUILayout.BeginHorizontal();		
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}
}
