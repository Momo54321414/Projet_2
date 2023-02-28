using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player _player;
    private float endTime = 0;
    private int _pointage = 0;
    private bool end = false;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (end == false)
        {
            if (collision.gameObject.tag == "Player")
            {
                end = true;
                _player.end();
                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                _pointage = _gestionJeu.getPointage();
                endTime = Time.time + _pointage;
                Debug.Log(endTime + " (Time: " + Time.time + ") (Pts: " + _pointage + ")");
                Debug.Log("GAME OVER");
            }
        }
    }
}