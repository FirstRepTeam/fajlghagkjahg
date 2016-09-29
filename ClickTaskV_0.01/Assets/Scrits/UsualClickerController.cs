using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;


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
    private float _healthbarMaxValue;
    private float critChanse = 1.05f;
    private BoxCollider2D _monsterHitbox;

    private float MonsterArmorLevel;

    public bool stopFastDecreaseTime = true;

    private float correctiveHitStrangth;
    // public EnemyController gg = new EnemyController();
    private MonstersBasicClass currentMonster;

    private float CurrentHealColdown = 5f;
    private const float CONST_HEAL_COLDON = 30f;

   
    void Start()
    {
     _healthObjLockalScaleX = _healthBar.transform.localScale.x;
        _healthbarMaxValue = _healthObjLockalScaleX;
        _monsterHitbox = Monster.GetComponent<BoxCollider2D>();
        correctiveHitStrangth = BigMom.ENC.ClickStrengthCorrective;
        currentMonster = BigMom.ENC.BufferMonster;
        BigMom.ENC.UsedMonstersList.Add(currentMonster);
        checkMonsterType();
        BigMom.ENC.MonsterWasKilled_E.AddListener(checkMonsterType);
        currentMonster.BasicHealth = _healthbarMaxValue;
        currentMonster.CurrentHealth = currentMonster.BasicHealth;
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


    private void checkMonsterType ()
    {
        if (currentMonster.TypeOfThisMonster == MonstersBasicClass.MonsterType.Healer)
        {
            BigMom.ENC.isHealerOnAMap = true;
        }
    }

    public void KillMonster()
    {
        
        BigMom.ENC.UsedMonstersList.Remove(currentMonster);
        if (currentMonster.TypeOfThisMonster == MonstersBasicClass.MonsterType.Healer)
        {
            BigMom.ENC.isHealerOnAMap = false;
        }
        if(currentMonster.TypeOfThisMonster == MonstersBasicClass.MonsterType.TimeEater)
        BigMom.PP.setNormalTimeDecrease();

        Destroy(Monster, 0.0f);
        StartCoroutine(WaitAfterDeath());

    }

    IEnumerator  WaitAfterDeath()
    {
        yield return new WaitForSeconds(0.1f);
        BigMom.ENC.MonsterWasKilled_E.Invoke();
    }

    private void StartHealingCast()
    { }

   


    private void ongoingProcesses()
    {
        //   currentMonster.CurrentHealth = _healthObjLockalScaleX;
        if (currentMonster.TypeOfThisMonster == MonstersBasicClass.MonsterType.TimeEater)
        {
            currentMonster.FastTime();
            }
            _healthBar.transform.localScale = new Vector3(currentMonster.CurrentHealth, 1f, 1f);
    }



    

    


    public void OnMouseDown() 
    {

        Instantiate(Scars, getScarsRandomPosition(), getScarsRandomRotation());

        if (currentMonster.CurrentHealth > 0)
        {

           
            _clickStrength = BigMom.PP.CalculateHit();
         //   Debug.Log(_clickStrength);
            Debug.Log(correctiveHitStrangth);
            currentMonster.CurrentHealth -= _clickStrength;


            _healthBar.transform.localScale = new Vector3(currentMonster.CurrentHealth, 1f, 1f);  
            BigMom.ENC.UpdateScore(); // we really need this?

        }

        if (currentMonster.CurrentHealth <= 0)
        {
            BigMom.ENC.countAliveMonsters--;
            if (BigMom.ENC.countAliveMonsters <= 0)
            {
                BigMom.ENC.StartCorutineOutside();
            }
            KillMonster();
            BigMom.ENC._scoreCounter++;
        }
            

      //  Debug.Log(_healthObjLockalScaleX);
    }


    


    void Update()
    {
        Debug.Log(currentMonster.TypeOfThisMonster.ToString());
        ongoingProcesses();
        // HealingAura();
        currentMonster.HealingAura(currentMonster);

        //  else { goToUsualSettings(); }
       
        if (BigMom.GC.TimeIsOutLetsEndThisGame)
        {
            
                KillMonster();
            if (currentMonster.TypeOfThisMonster == MonstersBasicClass.MonsterType.TimeEater)
            { stopFastDecreaseTime = true; }
            BigMom.ENC.WaitingForDestroying();        
        }

        CurrentHealColdown -= Time.deltaTime;
        



    }
   

  

}
