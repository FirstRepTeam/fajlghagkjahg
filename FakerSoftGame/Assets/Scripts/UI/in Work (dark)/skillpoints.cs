using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillpoints : MonoBehaviour {
public int points = 25;
public GameObject displayPoints;

    void Start()
    {
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        displayPoints.GetComponent<Text>().text = "Points "+ points;
    }

}
