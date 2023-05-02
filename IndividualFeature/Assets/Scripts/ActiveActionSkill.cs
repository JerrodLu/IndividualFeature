using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveActionSkill : MonoBehaviour
{
    public bool activated = false;

    [SerializeField]
    private GameObject PhaseCast;

    public void PhasecastActive()
    {
        if (activated == false)
        {
            GameObject phaseCast = Instantiate(PhaseCast);
            phaseCast.name = "Phase";
            activated = true;
        }
    }
}
