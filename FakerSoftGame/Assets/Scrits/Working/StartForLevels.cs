using UnityEngine;
using System.Collections;

public class StartForLevels : MonoBehaviour {

    
    public GameObject _levelPanel,_mapPanel;

    public void ShowLevel()
    {
        _levelPanel.SetActive(true);
        _mapPanel.SetActive(false);
    }

    

}
