using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerParametrs : MonoBehaviour {


    [HideInInspector]
    public float timeDecreaseCoeficient = 0.1f;

    [HideInInspector]
    public float HitDecreaseCoefForSpell = 1f;

    private const float BASE_HEALTH_DECREESE_COEFICIENT = 0.01f;
    private float _clickStrength;
  
    private float critChanse = 1.05f;

    private float correctiveHitStrangth = 1.0f;

    [SerializeField]
    private Slider fireS, airS, waterS, earthS;
    [SerializeField]
    private Text fireT, airT, waterT, earthT;
    [SerializeField]
    private GameObject Skills;



    public float CalculateSkills()
    {
        float damage = 0f;
        damage = (fireS.value - waterS.value) +
        (fireS.value + airS.value) +
        (waterS.value + earthS.value) +
        (earthS.value - airS.value);
        return damage;
    }


    public void SkillsCount()
    {
        fireT.text = fireS.value.ToString();
        airT.text = airS.value.ToString();
        waterT.text = waterS.value.ToString();
        earthT.text = earthS.value.ToString();
    }
    public void OnOffSkill()
    {
        Skills.SetActive(!Skills.activeSelf);
    }


    public void setNormalTimeDecrease()
    {
        timeDecreaseCoeficient = 0.1f;
    }

    public float CalculateTimeDecrease()
    {

        return timeDecreaseCoeficient;
    }

    public float CalculateHit(MonstersBasicClass monster)
    {
        _clickStrength = ((BASE_HEALTH_DECREESE_COEFICIENT + Random.Range(0.01f, 0.50f)) * CalculateCritChanse()) / Random.Range(0.5f + (BigMom.ENC._scoreCounter + 1f) / 5f, 1.4f + (BigMom.ENC._scoreCounter + 1f) / 5f);
        _clickStrength = _clickStrength * monster.ClickStrengthCorrectiveVector * HitDecreaseCoefForSpell;
        Debug.Log(monster.ClickStrengthCorrectiveVector.ToString());
        return _clickStrength;
        
    }

    private float CalculateCritChanse()
    {

        if (Random.Range(1f, 100f) * critChanse > 99)
            return 4.0f;
        else if (Random.Range(1f, 100f) * critChanse > 98)
            return 3.0f;
        else if (Random.Range(1f, 100f) * critChanse > 97)
            return 2.0f;
        else
            return 1.0f;
    }





}
