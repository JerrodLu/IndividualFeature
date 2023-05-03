using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSkillsBase : MonoBehaviour
{
    /*
    protected float cooldown = 10f;
    public int damage;
    protected float distance;

    [SerializeField]
    private ActiveActionSkill activeActionSkill;

    private void Update()
    {
        if (activeActionSkill.activated)
        {
            activeActionSkill.gameObject.SetActive(false);
            StartCoroutine(ActionSkill());
        }
        

    }
    
    // disable ActiveActionSkill for cooldown time
    private IEnumerator ActionSkill()
    {       
        yield return new WaitForSeconds(cooldown);
        //activeActionSkill.activated = false;
        
        activeActionSkill.gameObject.SetActive(true);
        //activeActionSkill.activated = false;
        StopCoroutine(ActionSkill());
    }
    */
}
