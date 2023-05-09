using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSkillsBase : MonoBehaviour
{
    
    protected float cooldown = 10f;
    public bool activated;
    private bool tempCD;

    [SerializeField]
    private Player player;
    [SerializeField]
    private GameObject PhaseCast;
    [SerializeField]
    private GameObject phaseSphere;
    [SerializeField]
    private GameObject phaseGrasp;
    [SerializeField]
    private Vector3 offset;

    private void Start()
    {
        activated = false;
        tempCD = false;
    }

    // FixedUpdate did not work
    private void Update()
    {
        PhaseCast.transform.position = player.transform.position + offset;
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

    public void PhasegraspActive()
    {
        if (activated == false && tempCD == false)
        {
            GameObject phasegrasp = Instantiate(phaseGrasp);
            phaseGrasp.name = "Grasp";
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

    public void PhaseSphere()
    {
        GameObject sphere = Instantiate(phaseSphere);
        sphere.name = "PhaseSphere";
    }
}
