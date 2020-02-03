using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldActivor : MonoBehaviour
{
    public GameObject shield;
    public bool activate = false;
    public float shieldTime = 0.5f;
    public float nextShield = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activate == true && Time.time > nextShield )
        {
            shield.SetActive(true);
            nextShield = Time.time + shieldTime;
        }
        else
        {
            shield.SetActive(false);
        }
    }
}
