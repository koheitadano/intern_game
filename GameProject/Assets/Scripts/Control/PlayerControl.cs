using UnityEngine;
using System.Collections;


//----------------------------------------
// PlayerControl
// プレイヤーの制御を記述
//----------------------------------------
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	// プレイヤーの移動速度を取得する変数
	private Vector3 _playerVelocity = Vector3.zero;
	// プレイヤーの現在の座標を保存する
	private Vector3 _playerPosition = Vector3.zero;

	// ジャンプ力
	private float _jumpPower = 5.0f;
	private Rigidbody _rigidBody;

	// アニメーションパラメータ
	private Animator _animator;
	private int _doJumpId;

	//====================
	// SerializeFieldMember
	//====================
	[SerializeField]
	JumpFloorEventDispacher JumpFloorEventDispacher = null;
	[SerializeField]
	CommonButton AccelerateButton = null;

	//====================
	// Method
	//====================
	// Use this for initialization
	void Start ()
	{
		_animator = GetComponent<Animator> ();
		_doJumpId = Animator.StringToHash ("DoJump");
		_rigidBody = GetComponent<Rigidbody> ();
		AccelerateButton.OnHold += OnAccelerateButtonHold;
		JumpFloorEventDispacher.OnJump += OnJump;

		// 移動量 * 移動係数
		_playerVelocity = Vector3.right * Constant.RateCoefficient;
		_animator.speed = 1.0f;

	}
	
	// Update is called once per frame
	void Update ()
	{



		// ｘ軸に対して +方向へ常に移動してゆく
		this.transform.position += _playerVelocity;
		// 現在の座標の保存
		_playerPosition = this.transform.position;

	}

	void OnJump()
	{
		// ジャンプ床に触れたときにジャンプアニメーションへ
		Debug.Log ("GetHitJumpFloor == true ");
		//ステート遷移中でなかったらジャンプできる
		if (!_animator.IsInTransition (0))
		{
			_rigidBody.AddForce ((Vector3.up + Vector3.right) * _jumpPower, ForceMode.VelocityChange);
			_animator.Play("DoJump");
//			_animator.SetBool (_doJumpId, true);
		}
//		_animator.SetBool (_doJumpId, false);
	}


	void OnAccelerateButtonHold(bool isHold)
	{
		// プレイヤーの移動速度を取得
		// 移動速度の調整
		if (isHold)
		{
			Debug.Log ("Accel == true ");
			_playerVelocity = Vector3.right * Constant.Accelerate;
			_animator.speed = 1.8f;
		}
		else
		{
			// 移動量 * 移動係数
			_playerVelocity = Vector3.right * Constant.RateCoefficient;
			_animator.speed = 1.0f;
		}
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
