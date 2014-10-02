using UnityEngine;
using System.Collections;

public class FieldControl : MonoBehaviour
{
	//====================
	// PrivateMember
	//====================
	private Vector3 _fieldRotation = Vector3.zero;

	//====================
	// SerializeFieldMember
	//====================
	[SerializeField] TouchControl Touch = null;

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
		// 画面がタッチされたら
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("test");
			_fieldRotation += Vector3.up * Constant.AngleOfRotation;

			// 回転補正
			if (_fieldRotation.y > 360)
			{
				_fieldRotation -= Vector3.up * 360;
			}
			if (_fieldRotation.y < 0)
			{
				_fieldRotation += Vector3.up * 360;
			}

			this.transform.Rotate(_fieldRotation);
		}


	}

	//====================
	// Property
	//====================

}
