using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Transform LoadingBar;
    public float curreantAmount;
    public float speed = 30;
    public GameObject firstScene, manu, butten, progresBar, loanding;
   
 void Update()
    {
        if (curreantAmount < 100)
        {
            curreantAmount += speed * Time.deltaTime;
            LoadingBar.GetComponent<Image>().fillAmount = curreantAmount / 100;
        }
        else
        {
            butten.SetActive(true);
            progresBar.SetActive(false);
            loanding.SetActive(false);
        }

    }
   public void Play()
    {
        manu.SetActive(true);
        firstScene.SetActive(false);
    }

}
