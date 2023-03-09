using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenStart : MonoBehaviour
{
    public GameObject[] startmapPeices;
    public GameObject bridgePeice;
    public int limit = 0;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0,startmapPeices.Length);
        GameObject  curPiece = Instantiate(startmapPeices[rand],transform.position, Quaternion.identity) as GameObject;
        int id = curPiece.GetComponent<Idenity>().type;

        if(id == 4){
            Instantiate(bridgePeice,curPiece.transform.GetChild(1).position - bridgePeice.transform.GetChild(0).position,Quaternion.identity);
        }
    }

    

}
