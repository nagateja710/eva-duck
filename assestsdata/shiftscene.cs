using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shiftscene : MonoBehaviour
{
    // Start is called before the first frame update
    public  GameObject thing1,thing2,thing3;

    public void restartt()
    {
        zone.scoreval = 0;
        duckmove.isalive = true;
        zone.health = 8;
        zone.zonenum = 0;
        zone.i = 0;
        duckmove.presentcoins = 0;

        SceneManager.LoadScene(zone.z[1]);
        // SceneManager.LoadScene("gameplay");
    }

    public void home2()
    {
        SceneManager.LoadScene("mainmenu1");
    }
    public void character()
    {
        SceneManager.LoadScene("char");
    }
    public void homee()
    {
      //  charselect.player= 0;
        zone.scoreval = 0;
        duckmove.isalive = true;
        zone.health = 8;
        zone.zonenum = 0;
        zone.i = 0;
        duckmove.presentcoins = 0;
        SceneManager.LoadScene("mainmenu1");
    }
  
    public void easy()
    {
        duckmove.jumpforce = 20f;
        spawner.mi = 6; spawner.mx = 8;
        enemy.jump = 15f;

        thing1.SetActive(false);
       if (duckmove.isalive)
        thing2.SetActive(true);
        else thing3.SetActive(true);
    }

    public void med()
    {
        duckmove.jumpforce = 19f;
        spawner.mi = 8;spawner.mx = 10;
        enemy.jump = 16f;
        thing1.SetActive(false);
        if (duckmove.isalive)
            thing2.SetActive(true);
        else thing3.SetActive(true);
    }

    public void hard()
    {
        duckmove.jumpforce = 18f;
        spawner.mi = 8; spawner.mx = 12;
        enemy.jump = 17f;
        thing1.SetActive(false);
        if(duckmove.isalive)
       thing2.SetActive(true);
        else thing3.SetActive(true);

    }

    public void Playgame()
    {
        SceneManager.LoadScene(zone.z[1]);

    }
}

