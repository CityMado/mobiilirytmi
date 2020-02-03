using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 10;


    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * Speed;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
