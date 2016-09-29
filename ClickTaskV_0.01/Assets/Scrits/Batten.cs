using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
public class Batten : MonoBehaviour {

    public GameObject settings, tavern, manu, shop, map, inventory, person;
    


    public void Map()
    {
        map.SetActive(true);
        manu.SetActive(false);
    }

    public void Inventory()
    {
        inventory.SetActive(true);
        manu.SetActive(false);
    }

    public void Tavern()
    {
        manu.SetActive(false);
        tavern.SetActive(true);
    }

    public void Shop()
    {
        shop.SetActive(true);
        manu.SetActive(false);
        tavern.SetActive(false);
    }

    public void Person()
    {
        person.SetActive(true);
        manu.SetActive(false);
    }

    public void Setting()
    {
        settings.SetActive(true);
        manu.SetActive(false);
    }

    public void BackManu()
    {
        manu.SetActive(true);
        tavern.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
        map.SetActive(false);
        person.SetActive(false);
        inventory.SetActive(false);
    }



    public void FightScene()
    {
        SceneManager.LoadScene("clickScene"); 
    }


}
