using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UsualClickerController : MonoBehaviour {

    private BoxCollider2D _enemyHitbox;

    [SerializeField]
    public GameObject _healthBar;

    [SerializeField]
    private GameObject Scars;

    public GameObject Monster;

    private const float MAX_SCALE_X_VALUE_FOR_HEALTHBAR = 12.4f;
    private const float BASE_HEALTH_DECREESE_COEFICIENT = 0.01f;
    private float _clickStrength;
    private float _healthObjLockalScaleX;
    private float critChanse = 1.05f;
    private BoxCollider2D _monsterHitbox;

    private float MonsterArmorLevel;

   public EnemyController gg = new EnemyController();



    void Start()
    {
     _healthObjLockalScaleX = _healthBar.transform.localScale.x;
        _monsterHitbox = Monster.GetComponent<BoxCollider2D>();

    }



    private float CalculateCritChanse()
    {

        if (Random.Range(1f, 100f)* critChanse > 99)
            return 4.0f;
        else if (Random.Range(1f, 100f)* critChanse > 98)
            return 3.0f;
        else if (Random.Range(1f, 100f)* critChanse > 97)
            return 2.0f;
        else
            return 1.0f;

        
    }

    public Vector3 getScarsRandomPosition()
    {
       Vector3 ScarPosition =  _monsterHitbox.transform.position;
        float randomX = Random.Range(-BigMom.ENC._monsterHitbox.size.x/3.0f, BigMom.ENC._monsterHitbox.size.x / 3.0f);
        float randomY = Random.Range(-BigMom.ENC._monsterHitbox.size.y / 2.0f, BigMom.ENC._monsterHitbox.size.y / 6.0f);

        ScarPosition = new Vector3(
            ScarPosition.x + randomX,
            ScarPosition.y + randomY,
            ScarPosition.z
            
            );
        return ScarPosition;
    }

    public Quaternion getScarsRandomRotation()
    {
        Quaternion ScarRotation = Scars.transform.rotation;
        ScarRotation = new Quaternion(
            ScarRotation.x,
            ScarRotation.y,
            Random.rotation.z,
            ScarRotation.w );
        return ScarRotation;
    }

    public void KillMonster()
    {
        Destroy(Monster);
    }

    public void OnMouseDown() 
    {

        Instantiate(Scars, getScarsRandomPosition(), getScarsRandomRotation());

        if (_healthObjLockalScaleX > 0)
        {

            _clickStrength = ((BASE_HEALTH_DECREESE_COEFICIENT + Random.Range(0.01f, 0.50f))* CalculateCritChanse()) / Random.Range(0.5f+ (BigMom.ENC._scoreCounter + 1f)/5f,1.4f + (BigMom.ENC._scoreCounter + 1f) / 5f)   ;
            Debug.Log(_clickStrength);
            _healthObjLockalScaleX -= _clickStrength;

            _healthBar.transform.localScale = new Vector3(_healthObjLockalScaleX, 1f, 1f);  
            BigMom.ENC.UpdateScore(); // we really need this?

        }

        if (_healthObjLockalScaleX <= 0)
        {

            BigMom.ENC.StartCorutineOutside();
            KillMonster();

        }
            

        Debug.Log(_healthObjLockalScaleX);
    }

    void Update()
    {
        if (BigMom.GC.TimeIsOutLetsEndThisGame)
        {
            KillMonster();
            BigMom.GC.TimeIsOutLetsEndThisGame = false;         
        }
    }
   

  

}
