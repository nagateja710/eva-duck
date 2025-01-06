using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zone : MonoBehaviour
{
    public int zon;
    public static int zonenum = 1;
  int zonenumtemp;

    public static float spawnmin, spawnmax, target;
    public static int scoreval = 0;
    public float starttpoint, awkval;
    public static bool clr=false, stopy, awk;
    static bool once1 = true, once2 = true;//------------------------------------changed
  //  float[] tr = { 50, 150, 200, 300, 400, 600,800};
    float[] tr = { 50, 150, 200, 300, 400, 600,800};
    public static int i = 0;//---------------------------------------overallzone num
    public static int health = 8;
    public static int timer;
    public GameObject[] heart;
    public GameObject[] sky;
    public GameObject[] player;
   static  int skynum=0,skynumtemp;

    GameObject duck;

    public GameObject hor, vert, targett, plc,endd;

    public GameObject span;

    Rigidbody2D mybody;

    public static string[] z = {"mainmenu", "zone1", "zone2" };


    public float maxdistance, grav;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("player") == 0) { player[0].SetActive(true); print("p1"); } else if (PlayerPrefs.GetInt("player") == 1) { player[1].SetActive(true);print("p2"); }
        if (once1){once1 = false;sky[0].SetActive(true); } 
        else { skynumtemp = skynum;
            while (skynum == skynumtemp) { skynum = Random.Range(0, 4); }
            sky[skynumtemp].SetActive(false); sky[skynum].SetActive(true); }
           
        
            if (GameObject.FindWithTag("duck"))
                duck = GameObject.FindWithTag("duck");
            mybody = duck.GetComponent<Rigidbody2D>();
            zonenum = zon;
            clr = false; stopy = true;

            cam1.ofset = 0f; cam1.minx = -100f; if (i < 7) target = tr[i]; else target = tr[6] + 200 * (i - 6);     // maxdistance = 44f;maxdistance = 33.1f;

            if (duck != null)
            {
                if (zonenum == 1)
                {
                    spawnmin = 1f; spawnmax = 3f; mybody.gravityScale = 5f;
                    plc.SetActive(true); targett.SetActive(true); StartCoroutine(ok());

                }

                else if (zonenum == 2)
                {
                    spawnmin = 1f; spawnmax = 1.5f; mybody.gravityScale = 0f;
                    cam1.minx = 2f;

                    plc.SetActive(true); targett.SetActive(true); hor.SetActive(false); vert.SetActive(true); StartCoroutine(ok());

                }
            
        }
    }

    private void Update()
    {
        if (duck != null)
        {
            if (zone.scoreval >= target) { print("zoneclr"); clr = true; span.SetActive(false); }


            if (zonenum == 1)
            {
                if (clr) { timer = 10; targett.SetActive(false); StartCoroutine(ended()); }

            }

            if (zonenum == 2)
            {

                if (clr) { timer = 10; targett.SetActive(false); mybody.gravityScale = 5f; StartCoroutine(ended()); }
            }

            if (clr)
            {
            }


            /*
             if (duck.transform.position.x > awkval && duck.transform.position.x < awkval+1 && once) { once = false; awk = true;targett.SetActive(true); }
             if (duck.transform.position.x > starttpoint && duck.transform.position.x < starttpoint + 1 && zonenum==2 && oncest) { oncest = false; startt = true; }



             if (awk && zonenum == 1) { StartCoroutine(ok()); }
             if (awk && zonenum==2) { cam1.minx = 2f;starttpoint = -4.4f;}

             if (zon==2 && startt) { mybody.gravityScale = 0f; awk = false; plc.SetActive(false);  hor.SetActive(false);vert.SetActive(true);span.SetActive(true); }
             if (zon == 2 && clr) { targett.SetActive(false); startt =false;hor.SetActive(true); vert.SetActive(false); mybody.gravityScale = 5f; }
             if(zon==1 && clr) { targett.SetActive(false); startt = false; }

                 if (score.scoreval >= target) { print("zoneclr"); clr = true; span.SetActive(false); }

             if (duck.transform.position.x > maxdistance) {
                 if (zonenum == 1) { i++; zonenum = 2; SceneManager.LoadScene(z2);health += 3; }
                 else if (zonenum == 2) { i++; zonenum = 1; SceneManager.LoadScene(z1); health += 3; }
             }
            */
        }


        for (int j = 0; j < heart.Length; j++) { if (j < health / 4) heart[j].SetActive(true); else heart[j].SetActive(false); }                               //H
        print(health + ">>" + heart.Length); if (health > 20) health = 15; else if (health < 0) health = -1;

    }

    IEnumerator ok()
    {
        yield return new WaitForSeconds(3f);
        stopy = false;
        plc.SetActive(false); span.SetActive(true);
      //  if (zonenum == 2) mybody.gravityScale = 0f;
    }

    IEnumerator ended()
    {
        /*  endd.SetActive(true);
          for (int ii = timer; ii >= 0; ii--)
          {    
              yield return new WaitForSeconds(1f);timer = ii;timer--;

          }

          */
       // endd.SetActive(true);
        yield return new WaitForSeconds(3f);
        i++; health += 4; zonenumtemp = zonenum; //----------------------------------------------------H

        while (zonenum == zonenumtemp)
        {
            zonenumtemp = Random.Range(1, 3);

            print(zonenum + "zzz" + zonenumtemp);
        }
        zonenum = zonenumtemp;
        duckmove.presentcoins += 5;
        if (zonenum==2)duckmove.presentcoins += 5;
        PlayerPrefs.SetInt("coins", (PlayerPrefs.GetInt("coins") +5));
        if (zonenum == 2) PlayerPrefs.SetInt("coins", (PlayerPrefs.GetInt("coins") + 5));
        SceneManager.LoadScene(z[zonenum]);
    }

}
/*
 
 awake---------------------------------------------

      if (duck.transform.position.x > maxdistance)
            {
                if (zonenum == 1) { i++; zonenum = 2; SceneManager.LoadScene(z2); health += 3; }
                else if (zonenum == 2) { i++; zonenum = 1; SceneManager.LoadScene(z1); health += 3; }
            }

    if (GameObject.FindWithTag("duck"))
            duck = GameObject.FindWithTag("duck");
             mybody= duck.GetComponent<Rigidbody2D>();
        //duckmove.right = false;
        zonenum = zon;
        clr = false;startt = false;awk = false;

        cam1.ofset = 0f; cam1.minx = -100f;
        if (zonenum == 1) { maxdistance = 44f; spawnmin = 1f; spawnmax = 3f;starttpoint = -3f;target = tr[i]; grav = 5f; awkval = starttpoint; }

        else if(zonenum==2){ maxdistance = 33.1f; spawnmin=1f;spawnmax=1.5f;awkval = 3f; starttpoint = 10f; target =tr[i];grav = 0f; }
 */

/*
   if(duck!=null)
        {
            if (duck.transform.position.x > awkval && duck.transform.position.x < awkval+1 && once) { once = false; plc.SetActive(true); awk = true;targett.SetActive(true); }
            if (duck.transform.position.x > starttpoint && duck.transform.position.x < starttpoint + 1 && zonenum==2 && oncest) { oncest = false; startt = true; }



            if (awk && zonenum == 1) { StartCoroutine(ok()); }
            if (awk && zonenum==2) { cam1.minx = 2f;starttpoint = -4.4f;}

            if (zon==2 && startt) { mybody.gravityScale = 0f; awk = false; plc.SetActive(false);  hor.SetActive(false);vert.SetActive(true);span.SetActive(true); }
            if (zon == 2 && clr) { targett.SetActive(false); startt =false;hor.SetActive(true); vert.SetActive(false); mybody.gravityScale = 5f; }
            if(zon==1 && clr) { targett.SetActive(false); startt = false; }

                if (score.scoreval >= target) { print("zoneclr"); clr = true; span.SetActive(false); }

            if (duck.transform.position.x > maxdistance) {
                if (zonenum == 1) { i++; zonenum = 2; SceneManager.LoadScene(z2);health += 3; }
                else if (zonenum == 2) { i++; zonenum = 1; SceneManager.LoadScene(z1); health += 3; }
            }
           
        }
 */