using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    Rigidbody2D myBody;
   // Transform duck;
    public float x11,x12,x21,x22;
    [SerializeField]
    public float speed;
        public static float jump=15f;
    public bool crossed=false;

    Animator anim;
    BoxCollider2D boxcoliderr;

    GameObject duck;

  //  GameObject duck;
   //public bool crossed = false;
    //float x = 1f;
    // Start is called before the first frame update
    void Awake()
    {
 
        myBody=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        duck = GameObject.FindWithTag("duck");
        anim.SetBool("clear", false);
        anim.SetBool("coin", false);
        boxcoliderr=GetComponent<BoxCollider2D>();
        crossed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (myBody.gravityScale ==5 &&((myBody.transform.position.x>x11 && myBody.transform.position.x<x12)|| (myBody.transform.position.x > x21 && myBody.transform.position.x < x22)))
        { myBody.velocity=new Vector2(speed, jump); }
        else
            myBody.velocity = new Vector2(speed, myBody.velocity.y);

        if (zone.clr) { speed = 0;myBody.gravityScale = 0; myBody.transform.localScale = new Vector3(0.5f,0.5f,0.5f); boxcoliderr.isTrigger = true; anim.SetBool("clear", true); myBody.transform.position = Vector3.MoveTowards(myBody.transform.position, duck.transform.position, 15 * Time.deltaTime); }
     
        
        if (myBody != null && crossed && duck!=null)
        {
          
           // if ()
            {
                speed =0;
              //  if (speed == 50f) speed = -50f;
                myBody.gravityScale = 0; myBody.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                boxcoliderr.isTrigger = true;
                anim.SetBool("coin", true); myBody.transform.position = Vector3.MoveTowards(myBody.transform.position, duck.transform.position, 20 * Time.deltaTime);
            }
        }
     
        //  if (speed > 0 && myBody.transform.position.x>duck.transform.position.x && crossed==false) { if (duckmove.isalive) score.scoreval += 10;crossed = true; }
        //  else if (speed < 0 && myBody.transform.position.x < duck.transform.position.x && crossed==false) { if (duckmove.isalive) score.scoreval += 10;crossed = true; }
    }
}
