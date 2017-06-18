using UnityEngine;
using System.Collections;
// Тут должны быть реализованы специальные способности игрока, которые он будет использовать на протяжении схватки.
public class PlayerSpells : MonoBehaviour {

	private float Coldown = 15f;
    private float duration = 6f;

    public GameObject rageSpell;

    public void onRageSpellClick()
    {
        BigMom.PP.HitDecreaseCoefForSpell = 10f;
        rageSpell.SetActive(false);
        StartCoroutine(WaitForSpellColdownAndEnable());
        StartCoroutine(WaitForSpellDurationThenOffEffects());
    }

    public void RefreshSpellColdown()
    {
        StopCoroutine(WaitForSpellColdownAndEnable());
        StopCoroutine(WaitForSpellDurationThenOffEffects());
        rageSpell.SetActive(true);
        BigMom.PP.HitDecreaseCoefForSpell = 1f;
    }

    private IEnumerator WaitForSpellColdownAndEnable()
    {
        yield return new WaitForSeconds(Coldown);
        rageSpell.SetActive(true);
    }

    private IEnumerator WaitForSpellDurationThenOffEffects()
    {
        yield return new WaitForSeconds(duration);
        BigMom.PP.HitDecreaseCoefForSpell = 1f;
    }

}
