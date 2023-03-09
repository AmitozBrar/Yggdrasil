using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerAdjust : MonoBehaviour
{
    SpriteRenderer spriteRend;
    // Start is called before the first frame update
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sortingOrder = (int)(transform.position.y * -100);
    }
}
