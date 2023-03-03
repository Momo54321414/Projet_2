using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player _player;
    private float endTime = 0;
    private int _pointage = 0;
    private bool end = false;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if(nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        if(end == true)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (sceneIndex == 1)
            {
                end = true;
                _player.end();
                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                _pointage = _gestionJeu.getPointage();
                endTime = Time.time + _pointage;
                Debug.Log(endTime + " (Time: " + Time.time + ") (Pts: " + _pointage + ")");
                Debug.Log("GAME OVER");
            }
            else
            {
                SceneManager.LoadScene(sceneIndex + 1);
            }
        }
    }
}