using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
	private Vector3 _playerVelocity = Vector3.zero;
	private Vector3 _playerPosition = Vector3.zero;
	private float _jumpPower = 7.0f;

	private Animator _animator;
	private Rigidbody _rigidBody;

	private int _doJumpId;


	[SerializeField]
	JumpFloorEventDispacher JumpFloorEventDispacher = null;
	[SerializeField]
	Goal OnEnterGoal = null;
	[SerializeField]
	CommonButton AccelerateButton = null;

	void Start ()
	{
		_rigidBody = GetComponent<Rigidbody> ();
		_animator = GetComponent<Animator> ();
		_doJumpId = Animator.StringToHash ("DoJump");

		AccelerateButton.OnHold += OnAccelerateButtonHold;
		JumpFloorEventDispacher.OnJump += OnJump;
		OnEnterGoal.OnEnter += OnEnterGoalToResultTransition;

		// 移動量 * 移動係数
		_playerVelocity = Vector3.right * Constant.RateCoefficient;
		_animator.speed = 1.0f;

	}
	
	void Update ()
	{
		this.transform.position += _playerVelocity;
		_playerPosition = this.transform.position;
	}

	void OnJump()
	{
		if (!_animator.IsInTransition (0))
		{
			_rigidBody.AddForce ((Vector3.up + Vector3.right) * _jumpPower, ForceMode.VelocityChange);
			_animator.Play("DoJump");
		}
	}


	void OnAccelerateButtonHold(bool isHold)
	{
		// プレイヤーの移動速度を取得
		// 移動速度の調整
		if (isHold)
		{
			Debug.Log ("Accel == true ");
			_playerVelocity = Vector3.right * Constant.Accelerate;
			_animator.speed = 1.6f;
		}
		else
		{
			// 移動量 * 移動係数
			_playerVelocity = Vector3.right * Constant.RateCoefficient;
			_animator.speed = 1.0f;
		}
	}

	void OnEnterGoalToResultTransition()
	{
		Application.LoadLevel("result");
	}


	public Vector3 Position
	{
		set{this.transform.position = value;}
		get{return this.transform.position;}
	}
}
