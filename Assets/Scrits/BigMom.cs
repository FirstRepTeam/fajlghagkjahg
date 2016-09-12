using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public static class BigMom
{
    

    private static bool _is_initialized = false;
    public static bool IsInitialized
    {
        get
        {
            return _is_initialized;
        }
    }

    //TODO make this fields readonly

    /// <summary>
    /// Enviroment Controller
    /// </summary>
    public static EnemyController ENC;

    public static UsualClickerController UCC;

    public static GameController GC;

    public static void Init()
    {


        ENC = GameObject.FindObjectOfType<EnemyController>();
        UCC = GameObject.FindObjectOfType<UsualClickerController>();
        GC = GameObject.FindObjectOfType<GameController>();
    }

}
