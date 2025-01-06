using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam1 : MonoBehaviour
{

    Transform duck;
    Vector3 temp;
    // string duckk="duck";

    public static float maxx = 100f, minx = -100f;
    public static float ofset=0;
   
    // Start is called before the first frame update
    void Start()
    {
     
        if (GameObject.FindWithTag("duck"))
        duck=GameObject.FindWithTag("duck").transform;
       
    }
    
    // Update is called once per frame
    void LateUpdate()//---------------performes after all update function
    {
      
        if (!duck) {  return; }//duck==null

         temp=transform.position;
         temp.x=duck.position.x+ofset;
         if(temp.x>maxx)temp.x=maxx;
         else if(temp.x<minx)temp.x=minx;
    //   if(zone.clr || zone.stopy) temp.y = duck.transform.position.y;
         transform.position=temp;

       /*
        if (zone.zonenum == 2)
        {
            if (duck.transform.position.x > -12) ofset = 6;
            else if (duck.transform.position.x > -15) ofset = 5.5f;
            else if (duck.transform.position.x > -19) ofset = 5;
            else if (duck.transform.position.x > -22) ofset = 4.5f;
            else if (duck.transform.position.x > -26) ofset = 4;
            else if (duck.transform.position.x > -28) ofset = 3.5f;
            else if (duck.transform.position.x > -31) ofset = 3;
            else if (duck.transform.position.x > -34) ofset = 2.5f;
            else if (duck.transform.position.x > -38) ofset = 2;
            else if (duck.transform.position.x > -42) ofset = 1.5f;
            else if (duck.transform.position.x > -45) ofset = 1;
            else if (duck.transform.position.x > -47) ofset = 0.5f;
        }
       */
      //-45 -38 -31 -26 -19 -12 -4
      //  Debug.Log($">>{duck.position},{transform.position}");

    }
   
}
