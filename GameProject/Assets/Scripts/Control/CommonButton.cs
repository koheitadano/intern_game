using UnityEngine;
using System.Collections;
using System;

public class CommonButton : UIButton
{
	//====================
	// PrivateMember
	//====================
	public event Action OnClick = null;
	public event Action<bool> OnHold = null;

	//====================
	// SerializeFieldMember
	//====================
	//====================
	// Method
	//====================
	public override void OnPress (bool isPressed)
	{
		if (isEnabled)
		{
			base.OnPress(isPressed);
			if(isPressed && OnClick != null)
			{
				OnClick();
			}
			if(OnHold != null)
			{
				OnHold(isPressed);
			}
		}
	
	}

}
