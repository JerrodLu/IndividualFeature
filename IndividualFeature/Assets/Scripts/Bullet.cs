using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5f;
    Vector3 moveDir = Vector3.forward;

    private void Update()
    {
        Move(moveDir);
    }

    private void Move(Vector3 Dir)
    {
        transform.Translate(Dir * speed *Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
