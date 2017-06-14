using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsExitChild : MonoBehaviour {

void OnMouseDown()
{
	this.transform.parent.gameObject.SetActive(false);
	this.transform.parent.parent.Find("options").gameObject.SetActive(true);
}
}
