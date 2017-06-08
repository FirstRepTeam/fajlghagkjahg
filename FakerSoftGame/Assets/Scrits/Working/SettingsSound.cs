using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSound : MonoBehaviour {

    public GameObject settingsSound;
    void OnMouseDown()
    {
		this.transform.parent.gameObject.SetActive(false);
        settingsSound.SetActive(true);
		
    }
}
