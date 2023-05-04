using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phasesphere : MonoBehaviour
{
    // add Time.deltaTime to make the sphere larger
    // this can be done in update
    private Vector3 rescale;

    private void Start()
    {
        rescale = new Vector3(2, 2, 2);
        StartCoroutine(Rescale());
    }

    private IEnumerator Rescale()
    {
        while (transform.localScale != rescale)
        {
            yield return new WaitForSeconds(5f);
            transform.localScale *= 1.2f;
            if (transform.localScale == rescale)
            {
                Destroy(this.gameObject);
            }
        }
        StopCoroutine(Rescale());
    }
}
