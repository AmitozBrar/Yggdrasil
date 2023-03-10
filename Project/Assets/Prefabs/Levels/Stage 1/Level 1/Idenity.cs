using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idenity : MonoBehaviour
{

    public int type;
    public int dir;
    public WorldGenStart lim;
    public GameObject[] rooms;
    public int[] sides;
    private bool hasSide;

    public void Start(){
        if(type == 0){
            bridgeToRoom();
        }
        else if(lim.limit > 0){
            roomToBridge(dir);
        }
        
    }

    public void bridgeToRoom(){
        int rand = Random.Range(0,rooms.Length);
        if(rooms[rand].GetComponent<Idenity>().type == 4){
            rooms[rand].GetComponent<Idenity>().dir = dir;
            Instantiate(rooms[rand],transform.GetChild(1).position - rooms[rand].transform.GetChild(dir).position,Quaternion.identity);
        }
    }
    public void roomToBridge(int sdir){
        for(int i = 0; i < 4; i++){
            if(sides[i] != sdir){
                lim.limit -= 1;
                Instantiate(rooms[sides[i]],transform.GetChild(sides[i]).position - rooms[sides[i]].transform.GetChild(0).position,Quaternion.identity);
            }
        }

    }
}
