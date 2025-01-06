using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] thing;

    public void Trigger()
    {
        if (thing[0].activeInHierarchy == true) {
            thing[0].SetActive(false); thing[1].SetActive(false);
            //thing[2].SetActive(false);
        }
        else if (thing[0].activeInHierarchy == false) { thing[0].SetActive(true); thing[1].SetActive(true); 
           // thing[2].SetActive(true);
        }
           }
    public void settingsss()
    {
        thing[0].SetActive(false);
        thing[1].SetActive(false);
    //    thing[2].SetActive(true);
    }
}
