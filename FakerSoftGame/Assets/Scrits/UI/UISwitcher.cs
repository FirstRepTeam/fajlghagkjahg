using UnityEngine;
using System.Collections;

public class UISwitcher : MonoBehaviour {

    public GameObject[] buttons;
    public GameObject[] backseens;
    bool[] buttonsState = { true, true,true,true,true};

    public void PlayerButtoOn()
    {
        if (buttonsState[0] == true)
        {
            CloseButtons();
            buttonsState[0] = false; 
            backseens[0].SetActive(false);
            backseens[1].SetActive(false);
            backseens[2].SetActive(true);
            backseens[3].SetActive(false);
            backseens[4].SetActive(false);
            buttons[5].SetActive(true);
        }
        else {
            CloseButtons();
        };


    }

    public void BagButtinOb() {
        if (buttonsState[1] == true)
        {
            CloseButtons();
            buttonsState[1] = false;
            backseens[0].SetActive(false);
        backseens[1].SetActive(false);
        backseens[2].SetActive(true);
        backseens[3].SetActive(false);
        backseens[4].SetActive(true);
        buttons[5].SetActive(true);
        }
        else
        {
            CloseButtons();
        };
    }

    public void MapButtonOn() {
        if (buttonsState[2] == true)
        {
            CloseButtons();
            buttonsState[2] = false;
            backseens[0].SetActive(false);
        backseens[1].SetActive(true);
        backseens[2].SetActive(false);
        backseens[3].SetActive(false);
        backseens[4].SetActive(false);
        buttons[5].SetActive(false);
        }
        else
        {
            CloseButtons();
        };
    }

    public void SettingButtonOn() { }

    public void ShopButtonOn() {
        if (buttonsState[4] == true)
        {
            CloseButtons();
            buttonsState[4] = false;
            backseens[0].SetActive(true);
        backseens[1].SetActive(false);
        backseens[2].SetActive(false);
        backseens[3].SetActive(false);
        backseens[4].SetActive(false);
        buttons[5].SetActive(false);
        }
        else
        {
            CloseButtons();
        };
    }

    public void SkillButtonOn() {
      
            backseens[0].SetActive(false);
        backseens[1].SetActive(false);
        backseens[2].SetActive(false);
        backseens[3].SetActive(true);
        backseens[4].SetActive(false);
        buttons[5].SetActive(true);
       
    }

 
    void CloseButtons()
    {
        buttonsState[0] = true;
        buttonsState[1] = true;
        buttonsState[2] = true;
        buttonsState[3] = true;
        buttonsState[4] = true;
        backseens[0].SetActive(false);
        backseens[1].SetActive(false);
        backseens[2].SetActive(false);
        backseens[3].SetActive(false);
        backseens[4].SetActive(false);
        backseens[5].SetActive(false);
        buttons[5].SetActive(false);
    }
}
