using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phasecast : MonoBehaviour
{
    private float speed = 3f;
    private Vector3 moveDir = Vector3.forward;

    private void Start()
    {
        StartCoroutine(Duration());
    }

    private void Update()
    {
        Move(moveDir);
    }

    private void Move(Vector3 Dir)
    {
        transform.Translate(Dir * speed * Time.deltaTime);
    }

    // Destroy phasecast fist after a certain amount of time
    private IEnumerator Duration()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}