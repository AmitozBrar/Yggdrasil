using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth  = 10;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    void Update(){
        if(health <= 0){
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    
}
