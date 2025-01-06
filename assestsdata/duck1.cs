using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck1 : MonoBehaviour
{
     [SerializeField]//------------------------used to use private outside this class



    public static float moveforce = 10f;
    public static float jumpforce = 20f;
   // float move = 0f;

    float movementX;
Rigidbody2D myBody;
Animator anim;
string WALK_ANIMATION ="walk" ;
string groundtag="ground";
bool isgrounded;


    // adjustments of keyboard controls
    public float horiz = 0 ;

SpriteRenderer sr;

    public GameObject alive, dead; //used for overlay
    public static bool isalive = true;

    string butt;

private void Awake() {
      //  GameObject  mainmenu.player;
    myBody=GetComponent<Rigidbody2D>();
    anim=GetComponent<Animator>();
    sr=GetComponent<SpriteRenderer>();
        
}

    // public float maxvelocity;
    // Start is called before the first frame update
    void Start()
    {
      // transform.position = new Vector3(0f, 2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
      
        duckmove();
        //animateduck(); 
        duckjump();
        horiz = Input.GetAxis("Vertical");



        if (horiz > 0)
        {
            Debug.Log("Right");
        }
        else if (horiz < 0)
        {
            Debug.Log("Left");
        }
        else
        {
            Debug.Log("noth");
            //Debug.Log();
        }

    }

    private void FixedUpdate()
    {

    }

    public void duckmove(){
        movementX = Input.GetAxisRaw("Horizontal");//print(movementX);
        myBody.velocity = new Vector3(moveforce * movementX, myBody.velocity.y);
      //  Debug.Log($"{movementX}\n");
    }
    void duckjump(){

        if(Input.GetButtonDown("Jump") && isgrounded){
            isgrounded=false;
            myBody.AddForce(new Vector2(0f,jumpforce), ForceMode2D.Impulse);
            Debug.Log("king");
        
        }

         
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(groundtag))
        {
            isgrounded = true;
            //Debug.Log("jumped");
        }
    }

        /*
        void animateduck(){
            if(movementX>0){
                anim.SetBool(WALK_ANIMATION,true);
            sr.flipX=false;
            }
            else if(movementX<0){
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX=true;
            }
            else anim.SetBool(WALK_ANIMATION,false);
        }




        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(groundtag))
        {
            isgrounded = true;
            //Debug.Log("jumped");
        }
    if (collision.gameObject.CompareTag("enemy")) { Destroy(gameObject); alive.SetActive(false); dead.SetActive(true); isalive = false; }

    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy")) { Destroy(gameObject); alive.SetActive(false); dead.SetActive(true); isalive = false; }
    }
        */
    }
