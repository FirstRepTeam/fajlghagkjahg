using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class tabSwitch : MonoBehaviour, IPointerClickHandler {
public GameObject skills;
public GameObject inv;
public GameObject stats;
public GameObject resetHeight1;
public GameObject resetHeight2;
private string currentTab;

void Start(){
	currentTab = gameObject.name;
}
void IPointerClickHandler.OnPointerClick(PointerEventData eventData){
	if(currentTab == "Tab_left"){
		inv.SetActive(false);
		stats.SetActive(false);
		skills.SetActive(true);
	}
	if(currentTab == "Tab_middle"){
		inv.SetActive(true);
		stats.SetActive(false);
		skills.SetActive(false);
	}
	if(currentTab == "Tab_right"){
		inv.SetActive(false);
		stats.SetActive(true);
		skills.SetActive(false);
	}
	resetHeight1.GetComponent<RectTransform>().sizeDelta = new Vector2 (100, 50);
	resetHeight1.GetComponent<Image>().color = new Color32(255,255,255,255);
	resetHeight1.transform.Find("Tab Name").GetComponent<Text>().fontSize = 14;
	resetHeight2.GetComponent<RectTransform>().sizeDelta = new Vector2 (100, 50);
	resetHeight2.GetComponent<Image>().color = new Color32(255,255,255,255);
	resetHeight2.transform.Find("Tab Name").GetComponent<Text>().fontSize = 14;
}
}