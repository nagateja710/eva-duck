using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class zonenum : MonoBehaviour
{

    public static int zon = 0;
    Text zonee;
    void Start()
    {

        zon = zone.i+1;
        zonee = GetComponent<Text>();
        zonee.text = ("Zone-" + zon);

    }

}
