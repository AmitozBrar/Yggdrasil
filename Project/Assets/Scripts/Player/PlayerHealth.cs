using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private SpriteRenderer spriteRend;

    public int maxHealth  = 3;
    public int health;
    public float iframeduration;
    public int numOfFlashes;
    
    // Start is called before the first frame update
    void Start(){
        health = maxHealth;
        spriteRend = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage){
        health -= damage;
        if(health <= 0){
            Destroy(gameObject);
        }
        StartCoroutine(invulerable());
    }

    public IEnumerator invulerable(){

        Physics2D.IgnoreLayerCollision(10,11,true);
        for (int i = 0; i < numOfFlashes; i++){
            spriteRend.color = new Color(1,0,0,0.5f);
            yield return new WaitForSeconds(iframeduration / (numOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iframeduration / (numOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(10,11,false);

    }
}
