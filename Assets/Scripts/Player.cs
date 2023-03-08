using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1000f;
    private Rigidbody _rb;

    private void Start()
    {
        Application.targetFrameRate = 50;

        _rb = GetComponent<Rigidbody>();

        // this.transform.position = new Vector3(0f, 0.5f, 0f);
    }

    private void FixedUpdate()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();
        transform.Translate(direction * Time.deltaTime * _speed);
        //_rb.velocity= direction * Time.fixedDeltaTime * _speed;
        //_rb.AddForce(direction * Time.fixedDeltaTime * _speed);
    }

    public void end()
    {
        gameObject.SetActive(false);
    }
}