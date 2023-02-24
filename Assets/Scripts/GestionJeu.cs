using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    private int _pointage;

    private void Start()
    {
        InstructionsDepart();
        _pointage = 0;
    }

    private static void InstructionsDepart()
    {
        Debug.Log("*** Course à obstacles");
        Debug.Log("*** Le but du jeu est d'atteindre la zone d'arrivée le plus vite possible.");
        Debug.Log("*** Obstacle = Penalite");
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log(_pointage);
    }
}