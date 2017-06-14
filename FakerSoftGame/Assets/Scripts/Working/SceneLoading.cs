using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneLoading : MonoBehaviour {

    [SerializeField]
    private GameObject _loadingBarPanel, _settingsPanel;

    public void ShowSettingsPanel()
    {
        _loadingBarPanel.SetActive(false);
        _settingsPanel.SetActive(true);
    }
    public void ShowLodingBarPanel()
    {
        _loadingBarPanel.SetActive(true);
        _settingsPanel.SetActive(false);
    }
    public void Apply()
    {

    }
    public void ShowUI()
    {
        SceneManager.LoadScene("SceneUI");
    }
}
