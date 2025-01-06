using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainrun : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {  
        anim.SetBool("walk", false);
        anim.SetBool("run", true);
        
    }
}
