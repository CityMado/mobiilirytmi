﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 3;
  

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        HealthSystem();
    }
    public void HealthSystem()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
