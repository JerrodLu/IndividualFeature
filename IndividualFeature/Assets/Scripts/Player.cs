using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInputActions playerInputActions;

    private float speed = 10f;
    private float rotateSpeed = 25f;
    //public bool activated;

    //[SerializeField]
    //private GameObject bullet;
    //[SerializeField]
    //private GameObject PhaseCast;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private ActiveActionSkill activeActionSkill;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        //playerInputActions.Player.FireBullet.performed += _ => Shoot();
        playerInputActions.Player.ActionSkillPhasecast.performed += _ => PhasecastActive();
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = playerInputActions.Player.Move.ReadValue<Vector3>();
        transform.Translate(moveDir * speed * Time.deltaTime);
        
        float rotateDir = playerInputActions.Player.MouseRotate.ReadValue<float>();
        transform.Rotate(Vector2.up * Time.deltaTime * rotateSpeed * rotateDir);
    }
    
    public void PhasecastActive()
    {
        activeActionSkill.PhasecastActive();
    }

    /*
    private void Shoot()
    {
        GameObject Bullet = Instantiate(bullet);
        Bullet.name = "bullet";
        Bullet.GetComponent<MeshRenderer>().material.color = Color.black;
    }
    */
}
