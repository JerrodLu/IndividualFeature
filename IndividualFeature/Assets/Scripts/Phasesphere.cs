using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phasesphere : MonoBehaviour
{
    private Vector3 rescale;
    public int damage = 50;

    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private Vector3 offset;

    private void Start()
    {
        rescale = new Vector3(.05f, .05f, .05f);
        transform.position = enemy.transform.position + offset;
    }

    private void FixedUpdate()
    {
        transform.localScale += rescale;
        if (transform.localScale.x >= 2f)
        {            
            Destroy(this.gameObject);
        }
    }
}
