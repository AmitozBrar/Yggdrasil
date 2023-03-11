using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idenity : MonoBehaviour
{

    public int type;
    public int dir;
    public WorldGenStart lim;
    public GameObject[] rooms;
    public GameObject[] drooms;
    public int[] sides;
    private bool hasSide;
    private int rand;

    public void Start(){

        if(type == 0){
            if(Physics2D.OverlapCircle(transform.GetChild(1).position,.4f) != null){
                if(Physics2D.OverlapCircle(transform.GetChild(1).position,1f,8) != null){
                    Destroy(gameObject);
                }
                return;
            }
            
            bridgeToRoom();
        }
        else if(type != 0){
            roomToBridge(dir);
        }
    }

    public void bridgeToRoom(){
        rand = Random.Range(0,rooms.Length);
        if(rooms[rand].GetComponent<Idenity>().type == 4 && lim.limit > 0){
            rooms[rand].GetComponent<Idenity>().dir = dir;
            Instantiate(rooms[rand],transform.GetChild(1).position - rooms[rand].transform.GetChild(dir).position,Quaternion.identity);
        }
        else if(rooms[rand].GetComponent<Idenity>().type == 3 && lim.limit > 0){
            rooms[rand].GetComponent<Idenity>().dir = dir;
            Instantiate(rooms[rand],transform.GetChild(1).position - rooms[rand].transform.GetChild(dir).position,Quaternion.identity);  
        }
        else if(rooms[rand].GetComponent<Idenity>().type == 2 && lim.limit > 0){
            rooms[rand].GetComponent<Idenity>().dir = dir;
            Instantiate(rooms[rand],transform.GetChild(1).position - rooms[rand].transform.GetChild(dir).position,Quaternion.identity);  
        }
        else{
            rand = Random.Range(0,drooms.Length);
            Instantiate(drooms[rand],transform.GetChild(1).position - drooms[rand].transform.GetChild(0).position,Quaternion.identity);
        }

    }
    
    void roomToBridge(int sdir){
        for(int i = 0; i < sides.Length; i++){
            if(sides[i] != sdir){
                lim.limit -= 1;
                Instantiate(rooms[sides[i]],transform.GetChild(sides[i]).position - rooms[sides[i]].transform.GetChild(0).position,Quaternion.identity);
            }
        }

    }

     private void OnTriggerEnter2D(Collider2D collision){
        Destroy(gameObject);
    }
}
