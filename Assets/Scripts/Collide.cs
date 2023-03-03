using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Collide : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    //[SerializeField] private GameObject _piege = default;
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    private bool isActv = false;
    //private Rigidbody _rb;

    private void Start()
    {
        foreach(var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
        //_rb = _piege.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isActv)
        {
            isActv = true;
            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(new Vector3(0f, 200f, 400f));
            }
            Debug.Log("HIT");
        }
    }
}