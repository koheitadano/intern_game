using UnityEngine;
using System.Collections;

public class FieldControl : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private bool _RightRotateFlag = false;
	private bool _LeftRotateFlag = false;
	private int _RotateFrameCounter = 0;

	//====================
	// SerializeFieldMember
	//====================
	[SerializeField]
	CommonButton RightButton = null;
	[SerializeField]
	CommonButton LeftButton = null;
	[SerializeField]
	PlayerControl Player = null;


	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
		// AddOnClick
		RightButton.OnClick += OnClickRight;
		LeftButton.OnClick += OnClickLeft;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// 1Frameあたりの回転を計算して
		// 制限Frame内で90度回転する
		if(_RightRotateFlag == true)
		{
			// 回転後にカウンターを進める
			transform.RotateAround(Player.Position, transform.up, GetRotatePerFrame());
			_RotateFrameCounter++;
			if(_RotateFrameCounter >= Constant.FrameInterval)
			{
				// フラグを落として
				// カウンターを初期化する
				_RightRotateFlag = false;
				_RotateFrameCounter = 0;
			}
		}
		else if(_LeftRotateFlag == true)
		{
			// 回転後にカウンターを進める
			transform.RotateAround(Player.Position, transform.up, -GetRotatePerFrame());
			_RotateFrameCounter++;
			if(_RotateFrameCounter >= Constant.FrameInterval)
			{
				// フラグを落として
				// カウンターを初期化する
				_LeftRotateFlag = false;
				_RotateFrameCounter = 0;
			}
		}
	}

	// 右回転ボタンの処理
	// 押されたらフラグをオンにする
	void OnClickRight()
	{
		// ButtonClick	
		Debug.Log ("Touch Right");
		_RightRotateFlag = true;
	}

	// 左回転ボタンの処理
	// 押されたらフラグをオンにする
	void OnClickLeft()
	{
		// ButtonClick	
		Debug.Log ("Touch Left");
		_LeftRotateFlag = true;
	}


	//====================
	// Property
	//====================
	// 1Frameあたりの回転角を返す
	int GetRotatePerFrame()
	{
		return Constant.AngleOfRotation / Constant.FrameInterval;
	}

}
