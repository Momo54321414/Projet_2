using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLeft : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        StartCoroutine(loop());
    }

    private IEnumerator loop()
    {
        while (true)
        {
            this.transform.position = new Vector3(-1.5f, 1.7f, -6.5f);

            _rb.AddForce(new Vector3(0f, 0f, -2000f));

            yield return new WaitForSeconds(2f);
        }
    }
}