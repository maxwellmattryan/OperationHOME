﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnTimer;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTimer, spawnTimer);
    }


    void Spawn()
    {
        SetCoordinates();
        Instantiate(Enemy);
    }

    void SetCoordinates()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, Random.Range(0, 360));
        transform.LookAt(Vector3.zero);
    }
}
