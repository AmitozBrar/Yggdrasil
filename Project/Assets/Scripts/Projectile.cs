using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float projectileSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.position += transform.right * projectileSpeed * Time.deltaTime;
    }

    //destroy fireball on hit
    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
    }
    
}
