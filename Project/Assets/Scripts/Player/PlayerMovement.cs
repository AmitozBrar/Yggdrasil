using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private SpriteRenderer spriteRend;

    Vector2 movement;
    // Start is called before the first frame update
    void Start(){
        spriteRend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    private void sortingLayerUpate(){
        spriteRend.sortingOrder = (int)(transform.position.y * -100);
    }
    

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        sortingLayerUpate();
    }
}
