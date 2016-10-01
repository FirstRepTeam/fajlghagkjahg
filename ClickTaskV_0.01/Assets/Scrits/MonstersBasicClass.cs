using UnityEngine;
using System.Collections;
using System.Collections.Generic;






public class MonstersBasicClass : MonoBehaviour {


    public enum MonsterType
    { TimeEater, Healer, Usual, Armored };



    public List<MonsterType> MonsterTypesList = new List<MonsterType> { MonsterType.Armored, MonsterType.Healer, MonsterType.Usual, MonsterType.TimeEater };

    public GameObject HealerBody;
    public GameObject UsualBody;
    public GameObject TimeEaterBody;
    public GameObject ArmoredBody;


    [HideInInspector]
    public  float ClickStrengthCorrectiveVector;

    [HideInInspector]
    public float SaveClickStrengthCorrectiveVector;

    // public  string TypeOfMonster;
    [HideInInspector]
    public Vector3 spawnSlot;
    [HideInInspector]
    public MonsterType TypeOfThisMonster;
    [HideInInspector]
    public GameObject monsterBody;
    public MonstersBasicClass currentMonster;

    public float CurrentHealth ;
    public float BasicHealth;

    public float HealColdown = 0f;
    public float HealCastTime = 0f;

    public bool StartHealCastSpelCountdown = false;

    public void initMonster(MonsterType _monsterType, Vector3 _spawnSpotNumber, MonstersBasicClass curmon )
    {
        //  ClickStrengthCorrectiveVector = _monsterHealthCorrectiveValue;
        TypeOfThisMonster = _monsterType;
        curmon.TypeOfThisMonster = _monsterType;

        curmon.spawnSlot = _spawnSpotNumber;
        //  monsterBody = _monsterBody;
        attachBodyToMonster(curmon);
        
        

    }

    private void attachBodyToMonster(MonstersBasicClass curmon)
    {
        switch (curmon.TypeOfThisMonster)
        {
            case (MonsterType.Armored):
               curmon.monsterBody = ArmoredBody;
                curmon.ClickStrengthCorrectiveVector = 1f;
                break;
            case (MonsterType.Healer):
                curmon.monsterBody = HealerBody;
                curmon.ClickStrengthCorrectiveVector = 1.5f;
                break;
            case (MonsterType.TimeEater):
                curmon.monsterBody = TimeEaterBody;
                curmon.ClickStrengthCorrectiveVector = 1.5f;
                break;
            case (MonsterType.Usual):
                curmon.monsterBody = UsualBody;
                curmon.ClickStrengthCorrectiveVector = 0.6f;
                break;
        }
        curmon.SaveClickStrengthCorrectiveVector = curmon.ClickStrengthCorrectiveVector;      
    }

    /*
     *  private void HealingSpellLogic()
    {
        if (BigMom.ENC.isHealerOnAMap)
        {
            if (CurrentHealColdown < 0)

            {
                if (currentMonster.CurrentHealth < currentMonster.BasicHealth/2f)
                {
                    
                }
  
          }



        }
    }

        private void HealDamagedTarget()
    {

        if (BigMom.ENC.isHealerOnAMap)
        {
           
        }



        if (_healthObjLockalScaleX < _healthbarMaxValue/2)
        {
         MonstersBasicClass randomMob =   BigMom.ENC.UsedMonstersList[Random.Range(1, BigMom.ENC.UsedMonstersList.Count)];

        }
    }
     * */


    public void FastTime()
    {
        BigMom.PP.timeDecreaseCoeficient = 0.35f;
    }

    private void checkExistingMonsterTypesInGame()
    {
        foreach (MonstersBasicClass mob in BigMom.ENC.UsedMonstersList)
        {
            if (mob.TypeOfThisMonster == MonsterType.Healer)
            {
                BigMom.ENC.isHealerOnAMap = true;
            }
            if (mob.TypeOfThisMonster == MonsterType.Armored)
            {
                BigMom.ENC.isArmorBufferOnAMap = true;
            }
        }
    }




    public void ArmoredBuff(MonstersBasicClass curmonster)
    {
        
        if (BigMom.ENC.isArmorBufferOnAMap )
        {
            curmonster.ClickStrengthCorrectiveVector = 0.5f;
        }
        else
        {
           curmonster.ClickStrengthCorrectiveVector = curmonster.SaveClickStrengthCorrectiveVector;
        }
    }

    public void HealingAura(MonstersBasicClass curmonster)
    {
        if (BigMom.ENC.isHealerOnAMap && curmonster.CurrentHealth < curmonster.BasicHealth && curmonster.TypeOfThisMonster != MonstersBasicClass.MonsterType.Healer)
        {

            curmonster.CurrentHealth += 1f * Time.deltaTime;
     
        }

    }

    public void StartHealCast(MonstersBasicClass curmonster)
    {
        if (curmonster.TypeOfThisMonster == MonsterType.Healer && curmonster.HealColdown <=0 )
        {
            bool isSomebodyNeedToBeHealed = false;
          foreach(MonstersBasicClass mob in BigMom.ENC.UsedMonstersList)
            {
                if (mob.CurrentHealth < mob.BasicHealth * 0.5f)
                {
                    isSomebodyNeedToBeHealed = true;
                }
            }
            if (isSomebodyNeedToBeHealed)
            {
                curmonster.HealColdown = 10f;
                isSomebodyNeedToBeHealed = false;
                curmonster.HealCastTime = 4f;
              curmonster.StartHealCastSpelCountdown = true;

                Debug.Log("Neeed heal");
             //   HealSomebody();
                
            }


          //  curmonster.CurrentHealth += 1f * Time.deltaTime;

        }

    }


    public void HealSomedsfbody()
    {
    //    StartCoroutine(HealCourutine());
    }

    public void HealSomebody()
    {
        //    yield return new WaitForSeconds(0.5f);

        Debug.Log("Im heled");
        float lowestHealth = 1000f;
        MonstersBasicClass weakestMonster = BigMom.ENC.UsedMonstersList[1];
        foreach (MonstersBasicClass mob in BigMom.ENC.UsedMonstersList)
        {
            if (mob.CurrentHealth < lowestHealth)
            {
                lowestHealth = mob.CurrentHealth;
                weakestMonster = mob;
            }
        }

        if (weakestMonster.CurrentHealth < weakestMonster.BasicHealth)
        {

            weakestMonster.CurrentHealth += weakestMonster.BasicHealth * 0.5f;

        }

        //  BigMom.GC.TimeIsOutLetsEndThisGame = false;

    }


    public void SpellColdown(MonstersBasicClass monstr)
    {
        monstr.HealColdown -= Time.deltaTime;
        if (monstr.HealColdown < -100)
        {
            monstr.HealColdown = -1;
        }
    }

    public void HealCastTimeCountdown (MonstersBasicClass monstr){
       
        if (monstr.StartHealCastSpelCountdown) {
            monstr.HealCastTime -= Time.deltaTime;
                if (monstr.HealCastTime < 0f)
                {
                monstr.StartHealCastSpelCountdown = false;
                HealSomebody();
                }
        }
    }




    void Update()
    {
        checkExistingMonsterTypesInGame();
        //  HealCastTimeCountdown();
        //  SpellColdown();
    }

  
}
