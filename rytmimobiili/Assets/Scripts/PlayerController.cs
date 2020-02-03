using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform Cannon;
    public GameObject BulletPrefab;
   // public float bulletDistance;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            Debug.Log("pressed");
        }
    }
      private void Shoot()
        {
        var bullet = Instantiate(BulletPrefab);
            bullet.transform.rotation = transform.rotation;
        bullet.transform.position = transform.position + transform.up;
            Debug.Log("fired");
        }
            
    }
