using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Collide : MonoBehaviour
{
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _rb.useGravity = true;
            _rb.AddForce(new Vector3(200f, 200f, 0f));
            Debug.Log("HIT");
        }
    }
}