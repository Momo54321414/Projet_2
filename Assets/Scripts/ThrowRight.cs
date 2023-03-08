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
            this.transform.position = new Vector3(-8.5f, 1.8f, 8f);

            _rb.AddForce(new Vector3(0f, 0f, 80f));

            yield return new WaitForSeconds(2f);
        }
    }
}