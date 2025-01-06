using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numbers : MonoBehaviour
{
    Text number;
    public string type;

    // Start is called before the first frame update
    void Start()
    { 
       number = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(type=="score")number.text = ("score: " + zone.scoreval);
        if (type == "target") number.text = ("Target " + zone.target);
        if (type == "clear") number.text = ("Next zone in.. " + zone.timer);
        // PlayerPrefs.SetInt("coins", 2);
        if (type == "coins") { number.text = ((duckmove.presentcoins+""));print("test"); }
        if (type == "tcoins") { number.text = ((PlayerPrefs.GetInt("coins") + "")); print("test"); }

    }
}
