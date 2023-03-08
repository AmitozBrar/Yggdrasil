using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public int edamage;
    public PlayerHealth playerHealth;
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHealth.TakeDamage(edamage);
        }
    }
}
