using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdel : MonoBehaviour
{
    public static dontdel instance,i2;
    public GameObject music;
   // public int Character;
    //public static int player;
    private void Awake()
    {
       // print("p="+player);
        //player = Character;
        DontDestroyOnLoad(music);
    }

    
    }

/*
if (instance == null)
{
    instance = this;
    DontDestroyOnLoad(music);
}

else { Destroy(music); }

*/
