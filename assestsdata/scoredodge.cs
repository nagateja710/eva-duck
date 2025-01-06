using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoredodge :MonoBehaviour
{
   // public  GameObject enmi;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy") && duckmove.isalive && zone.clr==false ) { zone.scoreval += 2; }
    }
}
