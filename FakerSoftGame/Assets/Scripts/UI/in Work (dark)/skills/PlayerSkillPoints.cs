using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkillPoints : MonoBehaviour {
public int points = 25;
public GameObject displayPoints;

    void Awake(){
        
        points += 25;
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        displayPoints.GetComponent<Text>().text = "Points "+ points;
    }

}
