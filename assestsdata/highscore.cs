using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int highval;
    Text high;
    void Start()
    {
        high = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        highval = zone.scoreval;
       // PlayerPrefs.SetInt("highscore", 0);
        if (PlayerPrefs.GetInt("highscore") < highval) PlayerPrefs.SetInt("highscore", highval);
        high.text = ("highscore: " + PlayerPrefs.GetInt("highscore"));
    }
}
