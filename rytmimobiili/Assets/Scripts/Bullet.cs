using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 10;
    public int delay = 2;
    public int damage = 1;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * Speed;    
    }

    // Update is called once per frame
    void Update()
    {
        bulletDestroy();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
         {
            var enemyH = collision.gameObject.GetComponent<Enemy>();
            enemyH.Health -= damage;
            Destroy(gameObject);
         }
        if (collision.gameObject.tag == "Shield")
        {
            Debug.Log("SHIELD HIT!!!!");
            Destroy(gameObject);

        }
    }


    void bulletDestroy()
    {
        Object.Destroy(gameObject, delay);
    }


}
