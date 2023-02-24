using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    private int _pointage = 0;

    private void Start()
    {
        Debug.Log("GAME START");
    }

    public void AugmenterPointage()
    {
        _pointage++;
    }

    public int getPointage()
    {
        return _pointage;
    }
}