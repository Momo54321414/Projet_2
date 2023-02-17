using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Private Methods
    void Start()
    {
        // Initial Player Position
        Application.targetFrameRate = 30;
        transform.position = new Vector3(0f, 0.5f, 0f);
    }

    void Update()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionY = Input.GetAxis("Vertical");
        Debug.Log(positionX + " , " + positionY);
    }
}