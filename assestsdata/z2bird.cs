using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z2bird : MonoBehaviour
{
    Rigidbody2D myBody;
    public float speed;
    public static float jump = 15f;

    void Awake()
    {
   
        speed = -5;
        myBody = GetComponent<Rigidbody2D>(); 
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            myBody.velocity = new Vector2(speed, myBody.velocity.y);
       // print(speed);
       
        if((myBody.transform.position.x>8) &&( myBody.transform.position.x<9.5f))
        {
            speed = 0;

          //  print("pos>>"+myBody.transform.position.x);
         StartCoroutine(pause());
        }
        if (myBody.transform.position.x < -11) speed = 0;
        
        
     //   myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(0.5f);speed =-50f; 
    }
}