using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phasegrasp : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private Vector3 offset;

    private Vector3 moveDir = Vector3.up;
    private float speed = 1f;

    private void Start()
    {
        transform.position = enemy.transform.position + offset;
    }

    private void Update()
    {
        if (transform.position.y <= 2f)
        {
            Move(moveDir);
        }
    }

    private void Move(Vector3 Dir)
    {
        transform.Translate(Dir * speed * Time.deltaTime);
    }
}
