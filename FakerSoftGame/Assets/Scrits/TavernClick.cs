using UnityEngine;
using System.Collections;

public class TavernClick : MonoBehaviour
{
    public GameObject PlayerUI;

    void OnMouseDown()
    {
        PlayerUI.SetActive(true);
    }
}
