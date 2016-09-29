using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

	public void ChangScen()
    {
        SceneManager.LoadScene("UIScene");
    }
}
