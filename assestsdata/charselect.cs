using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charselect : MonoBehaviour
{
    // Start is called before the first frame update
    // public static int player;

    public GameObject buy, select1, selected1;
    public GameObject select2, selected2;

    public static int x=1;


    private void Awake()
    {
        /*
         buy.SetActive(true);
         selected1.SetActive(true);
         select1.SetActive(false);
         selected2.SetActive(false);
         select2.SetActive(false);
        */

        if (PlayerPrefs.GetInt("buy") == x)
        {

            buy.SetActive(false);
            selected1.SetActive(true);
            select1.SetActive(true);
            selected2.SetActive(true);
            select2.SetActive(true);
            //if (buy) { selected2.SetActive(false);selected1.SetActive(true);}


            if (PlayerPrefs.GetInt("player") == 0)
            {
              selected1.SetActive(true);
              select1.SetActive(false);
              selected2.SetActive(false);
              select2.SetActive(true);
            }
            if (PlayerPrefs.GetInt("player") == 1)
            {
                selected2.SetActive(true);
                select2.SetActive(false);
                selected1.SetActive(false);
                select1.SetActive(true);
            }
        }

    }
    public void buyy()
    {
        if (PlayerPrefs.GetInt("coins") > 100f)
        {
            PlayerPrefs.SetInt("buy", x);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100);
            buy.SetActive(false);
            select2.SetActive(true);
            selected2.SetActive(false);
        }
    }

    public void select11()
    {
        if (select1 != null)
        {

            select1.SetActive(false);
            selected1.SetActive(true);
            selected2.SetActive(false);
            select2.SetActive(true);
            PlayerPrefs.SetInt("player", 0);
        }
        //  if (!buy) {selected2.SetActive(false);select2.SetActive(true);}
    }

    public void select22()
    {
        if (select2 != null)
        {
            select2.SetActive(false);
            selected2.SetActive(true);
            select1.SetActive(true);
            selected1.SetActive(false);
            PlayerPrefs.SetInt("player", 1);

        }
    }


    public void play()
    {
        SceneManager.LoadScene("mainmenu1");
    }
    public void temp()
    {

    }
}