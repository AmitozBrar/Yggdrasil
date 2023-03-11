using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenStart : MonoBehaviour
{
    public WorldGenStart limit_;
    public GameObject startPiece;
    public GameObject[] bridgePeice;
    public int limit;
    // Start is called before the first frame update
    void Start()
    {
        limit_.limit = Random.Range(15,50);
        int rand = Random.Range(0,3);
        GameObject  curPiece = Instantiate(startPiece,transform.position, Quaternion.identity) as GameObject;
        int id = curPiece.GetComponent<Idenity>().type;

        for(int i = 0; i <= rand; i++){
            Instantiate(bridgePeice[i],curPiece.transform.GetChild(i).position - bridgePeice[i].transform.GetChild(0).position,Quaternion.identity);
        }


    }

    

}
