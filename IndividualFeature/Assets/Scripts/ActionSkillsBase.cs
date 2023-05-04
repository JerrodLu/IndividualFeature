using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSkillsBase : MonoBehaviour
{
    
    protected float cooldown = 10f;
    public int damage;
    protected float distance;
    public bool activated;
    private bool tempCD;

    [SerializeField]
    private Player player;
    [SerializeField]
    private GameObject PhaseCast;
    [SerializeField]
    private GameObject phaseSphere;
    [SerializeField]
    private Vector3 offset;
    
    // for testing
    //Vector3 temp;

    private void Start()
    {
        activated = false;
        tempCD = false;
    }

    // FixedUpdate did not work
    private void Update()
    {
        //Debug.Log(temp);
        //temp = PhaseCast.transform.position;
        

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

    public void EndCD()
    {
        activated = false;
        tempCD = false;
    }

    public void PhaseSphere()
    {
        GameObject sphere = Instantiate(phaseSphere);
        sphere.name = "PhaseSphere";
        //sphere.transform.position = PhaseCast.transform.position;
        //Debug.Log(sphere.transform.position);
        //Debug.Log(PhaseCast.transform.position);
        //Debug.Log(temp);
    }
}
