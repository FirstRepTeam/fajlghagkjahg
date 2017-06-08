using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
    public GameObject settings;
	public GameObject soundControl;

    void OnMouseDown(){
		if(settings.activeInHierarchy){
			settings.SetActive(false);
			soundControl.SetActive(false);
		}
		else{
			settings.SetActive(true);
			soundControl.SetActive(true);
		}		
    }

}
