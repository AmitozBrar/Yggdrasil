using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenStart : MonoBehaviour
{
    public GameObject startPiece;
    public GameObject[] bridgePeice;
    public int limit;
    // Start is called before the first frame update
    void Start()
    {
        limit = 9;
        int rand = Random.Range(0,3);
        GameObject  curPiece = Instantiate(startPiece,transform.position, Quaternion.identity) as GameObject;
        int id = curPiece.GetComponent<Idenity>().type;

        for(int i = 0; i <= 0; i++){
            Instantiate(bridgePeice[i],curPiece.transform.GetChild(i).position - bridgePeice[i].transform.GetChild(0).position,Quaternion.identity);
        }


    }

    

}
