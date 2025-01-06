using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainbuttons : MonoBehaviour
{
    // Start is called before the first frame update
    // public string butt;
    // int player;
    public GameObject dog, bird;
    Animator d1, b1;

    private void Awake()
    {
        
        d1=dog.GetComponent<Animator>();
        b1=bird.GetComponent<Animator>();
        d1.SetBool("clear",false);
        b1.SetBool("clear", false);
    }
    public void Playgame()
    {

        /*     
      butt= UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
               if (butt == "b1") player = 0; 
              else if (butt == "b2") player=1;

             mainmenu.instance.Player = player;


         }
        */
        SceneManager.LoadScene("zone1");

    }
}
