using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    Transform duck;
    Vector3 ooo;
    Vector4 temp;

    float ofset;

   public float minx,maxx;

    


    // Start is called before the first frame update
    void Start()
    {
        duck=GameObject.FindGameObjectWithTag("duck").transform;
        ofset=duck.position.x-(transform.position.x);
       // Debug.Log(ofset);//10.91
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!duck) return;
        temp=transform.position;
        temp.x=duck.position.x-ofset;
         if(temp.x>maxx)temp.x=maxx;
         else if(temp.x<minx)temp.x=minx;
        transform.position=temp;

       // Debug.Log((duck.position)+"-"+(transform.position)+"="+((duck.position)-(transform.position)));
        
    }
}
