using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    [SerializeField]
    private RectTransform _healthTimeBar;

    [SerializeField]
    private GameObject _timeIsOut;

    public bool TimeIsOutLetsEndThisGame = false;

    void Start()
    {
        InvokeRepeating("TimeDecrease", 0, 0.05f);
        _timeIsOut.SetActive(false);
    }

    private void TimeDecrease()
    {
        _healthTimeBar.sizeDelta = new Vector2(_healthTimeBar.sizeDelta.x - 0.1f, _healthTimeBar.sizeDelta.y);
        if(_healthTimeBar.sizeDelta.x <= 0)
        {
            CancelInvoke("TimeDecrease");

            TimeIsOutLetsEndThisGame = true;
            _timeIsOut.SetActive(true);
        }
    }
	
}
