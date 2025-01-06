using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdelc : MonoBehaviour
{
    static dontdelc instance;
       public GameObject contrl;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(contrl);
        }

        else { Destroy(contrl); }

    }

}
