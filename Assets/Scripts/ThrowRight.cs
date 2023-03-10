using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRight : MonoBehaviour
{
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        StartCoroutine(loop());
    }

    private IEnumerator loop()
    {
        while (true)
        {
            this.transform.position = new Vector3(-6.5f, 1.7f, 10f);

            _rb.AddForce(new Vector3(0f, 0f, 2000f));

            yield return new WaitForSeconds(2f);
        }
    }
}