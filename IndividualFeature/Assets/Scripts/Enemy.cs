using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 500;
    private bool effectStatus;

    private ActionSkillsBase actionSkill;

    private void Start()
    {
        effectStatus = false;
    }

    private void Update()
    {
        if (hitPoints <= 100)
        {
            StopCoroutine(EffectDamage());
        }

        if (hitPoints == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "phaseCast")
        {
            hitPoints -= actionSkill.damage;
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "FOM")
        {
            hitPoints -= actionSkill.damage;
        }

        if (collision.transform.tag == "fracture")
        {
            effectStatus = true;
            StartCoroutine(EffectDamage());
        }
    }
    */
    private IEnumerator EffectDamage()
    {
        yield return new WaitForSeconds(3f);

        do
        {
            //hitPoints -= actionSkill.damage;
        } while (effectStatus == true);

        
    }
}
