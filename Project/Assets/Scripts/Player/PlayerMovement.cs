using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float diagonalAngle = 30f;

    
    public Stats spe; 
    public Rigidbody2D rb;
    private float moveSpeed;
    private SpriteRenderer spriteRend;

    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    void Start(){
        spriteRend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update(){


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       float hori = Input.GetAxisRaw("Horizontal");
       float vert = Input.GetAxisRaw("Vertical");

        moveSpeed = spe.spe;

        if((hori == 1  && vert == 1 )||(hori == 1  && vert == -1) ||(hori == -1  && vert == 1)||(hori == -1  && vert == -1)){
            Debug.Log("UR");

             float angle = diagonalAngle * Mathf.Deg2Rad; // convert angle to radians
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            
            movement = Vector2.Scale(movement, direction).normalized;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        
        }
        
        

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.sqrMagnitude > 0.01){
            animator.SetFloat("FaceVert", movement.y);
            animator.SetFloat("FaceHort", movement.x);
        }

        
        
        
    }
    
    private void sortingLayerUpate(){
        
        spriteRend.sortingOrder = (int)(transform.position.y * -100);
    }
    

    void FixedUpdate(){
        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        sortingLayerUpate();
    }

    public void door(int flag){
        if(flag == 1){
            Physics2D.IgnoreLayerCollision(10,12,true);
        }
        else{
            Physics2D.IgnoreLayerCollision(10,12,false);
        }
    }
}
