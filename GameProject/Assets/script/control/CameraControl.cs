using UnityEngine;
using System.Collections;

//----------------------------------------
// CameraControl
// カメラの制御を記述
// プレイヤーを常時一定距離から
// 見続ける追従カメラ
//----------------------------------------
public class CameraControl : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private Vector3 _cameraPosition = Vector3.zero;

	//====================
	// SerializeFieldMember
	//====================
	// プレイヤーの情報を取得
	[SerializeField] PlayerControl Player = null;

	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
		// Cameraの視点初期位置を設定
		this.transform.position = Player.Position
								+ (Vector3.up * Constant.PositionCoefficientY)
								+ (Vector3.back * Constant.PositionCoefficientZ);

		// Cameraの注視点初期位置を設定
		this.transform.LookAt(Player.Position);
	}

	// Update is called once per frame
	void Update ()
	{
		// Playerに追従してゆく
		this.transform.position =  Player.Position
								+ (Vector3.up * Constant.PositionCoefficientY)
								+ (Vector3.back * Constant.PositionCoefficientZ);
		// Cameraの注視点初期位置を設定
		this.transform.LookAt(Player.Position);


		// 現在の座標の保存
		_cameraPosition = this.transform.position;
	}

	//====================
	// Property
	//====================
}
