using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour {

    public GameObject skill1, skill2, skill3, skill4, skill5, skill6;
    private int level = 1;
    public Text UPLevel;

    public void UpLevel()
    {
        if (int.Parse(UPLevel.text) != 20)
        {
            string _string = UPLevel.text;
            int _index = 1 + int.Parse(_string);
            UPLevel.text = _index.ToString();
            level = int.Parse(UPLevel.text);
         }

        if (level == 3)
        {
            skill2.SetActive(true);
        }
        else if (level == 5)
        {
            skill3.SetActive(true);
        }
        else if (level == 10)
        {
            skill4.SetActive(true);
        }
        else if(level == 15)
        {
            skill5.SetActive(true);
        }
        else if(level == 20)
        {
            skill6.SetActive(true);
        }
    }

}
