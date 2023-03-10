using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(loop());
    }

    private IEnumerator loop()
    {
        while (true)
        {
            transform.position = new Vector3(0f, 0f, 0f);

            for (int i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(0.1f);
                transform.Translate(new Vector3(0f, 0.05f, 0f));
            }
        }
    }
}