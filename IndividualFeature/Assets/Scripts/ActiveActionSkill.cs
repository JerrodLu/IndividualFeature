using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveActionSkill : MonoBehaviour
{
    public bool activated;
    private bool tempCD;

    [SerializeField]
    private GameObject PhaseCast;

    private void Start()
    {
        activated = false;
        tempCD = false;
    }

    public void PhasecastActive()
    {
        if (activated == false && tempCD == false)
        {
            GameObject phaseCast = Instantiate(PhaseCast);
            phaseCast.name = "Phase";
            activated = true;
            tempCD = true;
            Invoke("EndCD", 3f);
        }
    }

    public void EndCD()
    {
        activated = false;
        tempCD = false;
    }
}
