using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Projectile : MonoBehaviour
{

    public float projectileSpeed = 4.5f;

    public Tilemap Collision;

    // Start is called before the first frame update
    private void Update()
    {   
        transform.position += transform.right * projectileSpeed * Time.deltaTime;
        Vector3Int collisionTileMap = Collision.WorldToCell(transform.position);
        if(Collision.GetTile(collisionTileMap) != null){
            Destroy(gameObject);
        }
        
        
    }


    //destroy fireball on hit
    private void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag == "Enemy"){
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Boundary"){
            Destroy(gameObject);
        }
        
    }
    
}
