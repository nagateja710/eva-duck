using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outofbounds : MonoBehaviour
{

    public GameObject alive, dead;
   // public bool crossed = false;
  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
           // Destroy(collision.gameObject);
            if (duckmove.isalive) zone.scoreval += 4;
            // collision.gameObject.GetComponent<> = true;
            collision.gameObject.GetComponent<enemy>().crossed = true;
        }

        else if (collision.CompareTag("duck")) {
            print("dead2"); 
            /*
            int tempcoin = zone.scoreval/10;
            int tempprevcoin = PlayerPrefs.GetInt("coins");
            PlayerPrefs.SetInt("coins", tempcoin + tempprevcoin);
            print("coins>>" + PlayerPrefs.GetInt("coins"));
            */
            Destroy(collision.gameObject);
            alive.SetActive(false);dead.SetActive(true); duckmove.isalive = false;}// duckmove. duckmove.  }

    }
}
