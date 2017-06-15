using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

    public GameObject MapUI;

    void OnMouseDown()
    {
        MapUI.SetActive(true);
    }
}
