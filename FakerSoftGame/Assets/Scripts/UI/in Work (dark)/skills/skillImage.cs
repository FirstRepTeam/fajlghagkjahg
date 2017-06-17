using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class skillImage : MonoBehaviour {
/*
в грид добавляем катинки +
прокачка по очереди в гриде
(иф предведуший актив то этот можно активировать )
активация 5 поинтов
проверка на активность по тегу
если поинтов меньше 0 дебаг лог недостаточно поинто

GetComponent<RectTransform>().hierarchyCount
перейти в родителя 
узнать сколько потомков  = длина 3
узнать который из них интересен
*/
	void Start(){
		GameObject[] objectArr = new GameObject[transform.childCount];
		Debug.Log("перед фор");
		for (int i = 0; i < objectArr.Length; i++)
		{
			 objectArr[i] = transform.GetChild(i).gameObject;
			 Debug.Log(objectArr[i].name);
		}
		Debug.Log("конец фор");
		var x = BigMom.PSP.points + 2;
		Debug.Log(BigMom.PSP.points +" "+ x);
	}

}
