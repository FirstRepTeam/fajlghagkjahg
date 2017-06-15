using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class testscr : MonoBehaviour, IPointerClickHandler  {
/*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
	skillpoints lpoint;
private int points5;
	void Start()
	{
		lpoint = GetComponent<skillpoints>();
	}
void IPointerClickHandler.OnPointerClick(PointerEventData eventData){
	//Debug.Log(GetComponent<RectTransform>().GetComponentsInParent);
	// Debug.Log(GetComponent<RectTransform>().hierarchyCapacity);
/*	Debug.Log(GetComponentsInParent<RectTransform>());
        foreach (float masive in masive) {
            print(masive);
        }*/
		points5 = lpoint.points;
		Debug.Log(points5);
		
		Debug.Log(lpoint.points);

}
}