using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Back : MonoBehaviour {
    public GameObject PlayerUI;
    public GameObject ShopUI;
    public GameObject MapUI;
    public GameObject LevelUI;
    public void CloseMapUI()
    {
        MapUI.SetActive(false);
        LevelUI.SetActive(false);
    }
    public void ClosePlayerUI()
    {
        PlayerUI.SetActive(false);
    }
    public void CloseShopUI()
    {
        ShopUI.SetActive(false);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("clickScene");
    }
    public void LevelUIShow()
        {

        LevelUI.SetActive(true);
        MapUI.SetActive(false);

    }
}
