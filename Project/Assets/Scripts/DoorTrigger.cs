using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int flag = 1;

    public PlayerMovement pm;
    public void Start(){
        flag = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision){
        
        if(collision.gameObject.tag == "Player"){
            pm.door(flag);
            if(flag == 1){
                flag = 0;
            }
            else{
                flag = 1;
            }
        }
        
    }

}
