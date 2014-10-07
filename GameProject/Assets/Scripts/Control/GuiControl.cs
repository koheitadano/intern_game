using UnityEngine;
using System.Collections;
using System;


public class GuiControl : MonoBehaviour
{
	void Start()
	{
		guiText.text = "ClearTime ◆"+PlayerPrefs.GetString("minites")+":"+PlayerPrefs.GetString("second")+":"+PlayerPrefs.GetString("frame")+"◆";
	}
}
