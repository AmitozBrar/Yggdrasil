using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 1f;
    private Vector2 movement;

    public float checkRadius;

    public float attackRadius;
    private Animator animator;

    private bool isInChaseRange;
    private bool isInAttackRange;

    public LayerMask whatIsPlayer;
    private Transform target;
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("isRunning", isInChaseRange);
        isInChaseRange = Physics2D.OverlapCircle(transform.position , checkRadius, whatIsPlayer );
        isInAttackRange = Physics2D.OverlapCircle(transform.position , attackRadius, whatIsPlayer );

        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        movement = direction;

        direction.Normalize();
        

        


        //Debug.Log(direction);
    }
    void FixedUpdate(){
        //moveCharacter(movement);

        if(isInChaseRange &&  !isInAttackRange){
            moveCharacter(movement);
            Debug.Log("chase");
        }
        if(isInAttackRange){
            rb.velocity = Vector2.zero;
            Debug.Log("attack");
        }

    }
    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    
}
