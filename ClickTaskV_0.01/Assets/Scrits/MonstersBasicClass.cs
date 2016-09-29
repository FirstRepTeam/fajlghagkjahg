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
        switch (TypeOfThisMonster)
        {
            case (MonsterType.Armored):
               curmon.monsterBody = ArmoredBody;
                curmon.ClickStrengthCorrectiveVector = 0.6f;
                break;
            case (MonsterType.Healer):
                curmon.monsterBody = HealerBody;
                curmon.ClickStrengthCorrectiveVector = 1.5f;
                break;
            case (MonsterType.TimeEater):
                curmon.monsterBody = TimeEaterBody;
                curmon.ClickStrengthCorrectiveVector = 1.2f;
                break;
            case (MonsterType.Usual):
                curmon.monsterBody = UsualBody;
                curmon.ClickStrengthCorrectiveVector = 1f;
                break;
        }          
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


    public void HealingAura(MonstersBasicClass curmonster)
    {
        if (BigMom.ENC.isHealerOnAMap && curmonster.CurrentHealth < curmonster.BasicHealth && curmonster.TypeOfThisMonster != MonstersBasicClass.MonsterType.Healer)
        {

            curmonster.CurrentHealth += 1f * Time.deltaTime;


            
        }

    }


    void Update()
    {
   
    }

  
}
