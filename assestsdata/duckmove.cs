using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class duckmove : MonoBehaviour
{
   
    public static float speed=10f;
    public float flyspeed=12f;
    public static float jumpforce=20f;
     float move=0f,fly=0f;
    int coins;

    bool left=false;
 bool right=false;
    bool hop = false;
    bool up = false;
    bool down = false;


    string walk = "walk";
    string groundtag = "ground";
    bool isgrounded=true;
    public static int presentcoins = 0;

    public  GameObject alive, dead; //used for overlay
    public static bool isalive=true;

   Rigidbody2D myBody;
    public static Transform x;

    Animator anim;
    SpriteRenderer sr;

    float keymove,keyfloat;

    // Start is called before the first frame update
    private void Awake()
    {
        //  GameObject  mainmenu.player;
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        anim.SetBool("run", false);
        x = GetComponent<Transform>();
       
        
    }
    public void Downleft()
    {
        left = true;
    }
    public void Upleft()
    {
        left = false;
    }
    public void Downright()
    {
        right = true;
    }

    public void Upright()
    {
        right = false;

    }

    public void Downdown()
    {
        down = true;
    }
    public void downup()
    {
        down = false;
    }
    public void upup()
    {
        up= false;
    }

    public void Updown()
    {
       up = true;

    }
    public  void jumpdown()
    {
        hop = true;
    }

    public void jumpup()
    {
        hop = false;
    }
    void movement()
    {
        keymove = Input.GetAxisRaw("Horizontal");
        if (left|| keymove<0f){ move = -1f; } 
        else if (right || keymove >0f) { move = +1f; }
        else { move = 0;}
  myBody.velocity = new Vector3(move * speed, myBody.velocity.y);

        if (zone.zonenum == 2 )
        {    
            keymove = Input.GetAxisRaw("Vertical");
            if (down || keymove < 0f) { fly = -1f; }
            else if (up || keymove > 0f) { fly = +1f; }
            else { fly = 0; }
            myBody.velocity = new Vector3(myBody.velocity.x, fly * flyspeed);
        }
    }

   void jump()
    {
        bool jmp = Input.GetButtonDown("Jump");
        if ((hop || jmp )&& isgrounded) {
            isgrounded = false;
            myBody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }
    }
    
    void animateduck()
    {
        if (move > 0 || up == true || down == true)
        {
            anim.SetBool(walk, true);
            sr.flipX = false;
        }
        else if (move < 0)
        {
            anim.SetBool(walk, true);
            sr.flipX = true;
        }
        else anim.SetBool(walk, false);
         if (fly > 0)
        {
            anim.SetBool("fly", true);
           // sr.flipX = false;
        }
        else if (fly < 0)
        {
            anim.SetBool("fly", true);
           // sr.flipX = true;
        }
        else anim.SetBool("fly", false);

      
        //215  361
        /*
        float xx = myBody.transform.position.x;
        if ((xx > 83f && xx < 85f) || (xx > 212f && xx < 215f) || (xx > 361f && xx < 365f))
        {
  int xxx = Random.Range(0, 3);print("x=" + xxx);
            switch (xxx)
            {
               // case 0: myBody.transform.position = new Vector3(361f, myBody.transform.position.y); break;
                case 0: { myBody.transform.position = new Vector3(86f, myBody.transform.position.y);print(0); break; }
                case 1: { myBody.transform.position = new Vector3(216f, myBody.transform.position.y); print(1); break; }
                case 2: { myBody.transform.position = new Vector3(-55f, myBody.transform.position.y); print(2); break; }
            }
        }
       // if (myBody.transform.position.x > 85f && x==0) myBody.transform.position = new Vector3(-55f, myBody.transform.position.y);
    
*/
  }
    private void Update()
    {
        
        movement();
        animateduck();
       // if(zone.zonenum==2 && zone.startt) { left = false; right = false; sr.flipX = false; }
        jump();
        
        // print(jumpforce);

    }

        



void OnCollisionEnter2D(Collision2D collision)
{

    if (collision.gameObject.CompareTag(groundtag))
    {
        isgrounded = true;
        //Debug.Log("jumped");
    }
        if (collision.gameObject.CompareTag("enemy")) {
            if (collision.gameObject.GetComponent<enemy>().crossed) { Destroy(collision.gameObject); }
            
            else if (zone.clr == false)
            {
                zone.health-=4;//---------------------------------------------------------H
                print("dead");
                if (zone.health <0)
                {
                    print("dead2"); Destroy(gameObject);
                    /*
                    int tempcoin = zone.scoreval/10;
                    int tempprevcoin = PlayerPrefs.GetInt("coins");
                    PlayerPrefs.SetInt("coins", tempcoin + tempprevcoin);
                    print("coins>>" + PlayerPrefs.GetInt("coins"));
                    */
                    alive.SetActive(false);
                    dead.SetActive(true);
                    isalive = false;
                }
                else if (zone.health > -1) { Destroy(collision.gameObject); }
            
            }
            else if (zone.clr) { zone.health++; Destroy(collision.gameObject); }
            
        }

}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            /* if (zone.clr == false)
             { print("dead2"); Destroy(gameObject);
                 int tempcoin = zone.scoreval/10;
                 int tempprevcoin = PlayerPrefs.GetInt("coins");
                 PlayerPrefs.SetInt("coins", tempcoin+tempprevcoin);
                 print("coins>>"+PlayerPrefs.GetInt("coins"));
                  alive.SetActive(false); dead.SetActive(true); isalive = false;
             }
            */
            if (zone.clr) { zone.health++; Destroy(collision.gameObject); }
            else if (collision.gameObject.GetComponent<enemy>().crossed) {
                presentcoins += 1;
                PlayerPrefs.SetInt("coins", (PlayerPrefs.GetInt("coins")+1));
                Destroy(collision.gameObject);
            }
        }
    }
}

/*
  void duckjump(){
        if(Input.GetButtonDown("Jump") && isgrounded){
            isgrounded=false;
            myBody.AddForce(new Vector2(0f,jumpforce), ForceMode2D.Impulse);
            Debug.Log("king");
        
        }

     
    }
 */