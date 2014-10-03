using UnityEngine;
using System.Collections;

//----------------------------------------
// PlayerControl
// プレイヤーの制御を記述
//----------------------------------------
public class PlayerControl : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	// プレイヤーの移動速度を取得する変数
	private Vector3 _playerVelocity = Vector3.zero;
	// プレイヤーの現在の座標を保存する
	private Vector3 _playerPosition = Vector3.zero;

	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		// プレイヤーの移動速度を取得
		// 移動量 * 移動係数
		_playerVelocity = Vector3.right * Constant.RateCoefficient;

		// ｘ軸に対して +方向へ常に移動してゆく
		this.transform.position += _playerVelocity;

		// 現在の座標の保存
		_playerPosition = this.transform.position;
	}

	//====================
	// Property
	//====================
	// 現在の座標を取得する
	public Vector3 Position
	{
		set{this.transform.position = value;}
		get{return this.transform.position;}
	}
}
