using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributes 
    [SerializeField] private float _speed = 10f;

    // Private Methods
    private void Start()
    {
        // Initial Player Position
        this.transform.position = new Vector3(0f, 0.5f, 0f);
    }

    private void Update()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _speed);
    }
}