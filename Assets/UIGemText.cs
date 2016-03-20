using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIGemText : MonoBehaviour {

	public Text gemText;
	void Update () 
	{
		gemText.text = "x " + PlayerStatus.maxGems; 
	}
}
