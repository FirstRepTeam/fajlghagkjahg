using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {
    public GameObject ShopUI;

  void OnMouseDown ()
    {
        ShopUI.SetActive(true);
    }
}
