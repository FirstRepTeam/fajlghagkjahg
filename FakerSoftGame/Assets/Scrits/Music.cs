using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Music : MonoBehaviour
{
    public bool on = true;
    public AudioSource mus;
    public GameObject off;
    void Start()
    {
        off.SetActive(false);
        mus.Play();
    }
    public void music()
    {
        if (on == true)
        {
            on = false;
            
            mus.mute = false;
            off.SetActive(false);
        }
        else if (on == false)
            {
                mus.mute = true;
                on = true;
            off.SetActive(true);
        }
        }
    }

