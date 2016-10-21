using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class TestParamsUI : MonoBehaviour {


    
    public GameObject DevUI;
    
    [SerializeField]
    private InputField _basicInputClickDamage, _basicImputCritChance, _basicInputMultiplyCritPower, _basicInputMultiplyMagicPower,
        _basicInputMultiplyClodoun, _basicInputResistCoef, _basicInputPower, _basicInputAgility, _basicInputIntellect, _basicInputStamina;

  

    public InputField _ETKSAIcoef, _ETKInputLvlExecutioner, _ETKInputLvlrush, _ETKInputLvlmagicArmor;

  /*  [SerializeField]
    private Text _changInputLVLValue, _changInputClickDamage, _changInputCritChance, _changInputMultiplyCritPrower,
   _changInputMultiplySkillPower, _changInputMultiplyColdoun, _changInputResistCoef, _changInputFinalPower, _changInputFinalAgility,
   _changInputFinalIntellect, _changInputFinalStamin, _changInputMultiplyOfCritPower, _changInputMultiplyOfColdoun;*/


    public void BasicParamsConferm()
    {
        BigMom.PP._basicClickDamage = float.Parse(_basicInputClickDamage.text);
        BigMom.PP._basicCritChance = float.Parse(_basicImputCritChance.text);
        BigMom.PP._basicMultiplyMagicPower = float.Parse(_basicInputMultiplyCritPower.text);
        BigMom.PP._basicMultiplyCritPower = float.Parse(_basicInputMultiplyCritPower.text);
        BigMom.PP._basicMultiplyColdoun = float.Parse(_basicInputMultiplyClodoun.text);
        BigMom.PP._basicResistCoef = float.Parse(_basicInputResistCoef.text);
        BigMom.PP._power = float.Parse(_basicInputPower.text);
        BigMom.PP._agility = float.Parse(_basicInputAgility.text);
        BigMom.PP._intellect = float.Parse(_basicInputIntellect.text);
        BigMom.PP._stamina = float.Parse(_basicInputStamina.text);
    }

    public void EtcChanges()
    {
        BigMom.PP._SAICoef = float.Parse(_ETKSAIcoef.text);
        BigMom.PP._passiveLvlExecutioner = float.Parse(_ETKInputLvlExecutioner.text);
        BigMom.PP._passiveLvlmagicArmor = float.Parse(_ETKInputLvlmagicArmor.text);
        BigMom.PP._passiveLvlrush = float.Parse(_ETKInputLvlrush.text);
    }
    public void OpenHIde()
    {
        DevUI.SetActive(!DevUI.activeSelf);
         
    }
}
