using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Projectile : MonoBehaviour
{

    public float projectileSpeed = 4.5f;
    public Stats stat;
    public EnemyHealth ehealth;
    

    // Start is called before the first frame update
    private void Update()
    {   
        transform.position += transform.right * projectileSpeed * Time.deltaTime;
    }


    //destroy fireball on hit
    private void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag == "Player"){
            return;
        }
        else if(collision.gameObject.tag == "Enemy"){
            ehealth.health -= 1;
            Destroy(gameObject);
        }
        else{
            //Destroy(gameObject);
        }

        
        
        
        
    }
    
}
