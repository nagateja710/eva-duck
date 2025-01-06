using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour

{
   
    [SerializeField]
    private GameObject[] spawn ;//array of enemies

    private GameObject spawned;//enemy spawned


    public Transform[] place;

    int randomindex;
    int randomdirection,randomheight;

    public static float mi = 6, mx = 8;



    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(spawnedmonsters());
    }
    IEnumerator spawnedmonsters()
    {
        while (duckmove.isalive)
        {
            //if () break;
                yield return new WaitForSeconds(Random.Range(zone.spawnmin,zone.spawnmax));

            if (zone.zonenum == 1)
            {
            randomindex = Random.Range(1, 4);
            randomdirection = Random.Range(0, 2);
             }

            if (zone.zonenum == 2)
            {
                randomindex = 0;
                randomdirection = Random.Range(2, 6);
            }

  spawned = Instantiate(spawn[randomindex]);
           

                /*     if (randomdirection == 0)//right
                      {
                     spawned.transform.position = place[0].position;
                     spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                     spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                     }else if (randomdirection == 1)
                     {
                         spawned.transform.position = place[1].position;
                         spawned.GetComponent<enemy>().speed = Random.Range(mi, mx);
                         spawned.transform.localScale = new Vector3(-2f, 2f, 2f);

                     }
                */

              //  randomheight = Random.Range(2, place.Length);///--------------------------------------
                switch (randomdirection)
                {
                    case 0:
                        spawned.transform.position = place[0].position;
                        spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                        break;
                    case 1:
                        spawned.transform.position = place[1].position;
                        spawned.GetComponent<enemy>().speed = Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(-2f, 2f, 2f);
                        break;
                    case 2:
                        spawned.transform.position = place[2].position;
                        spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                        break;
                    case 3:
                        spawned.transform.position = place[3].position;
                        spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                        break;
                    case 4:
                        spawned.transform.position = place[4].position;
                        spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                        break;
                    case 5:
                        spawned.transform.position = place[5].position;
                        spawned.GetComponent<enemy>().speed = -Random.Range(mi, mx);
                        spawned.transform.localScale = new Vector3(2f, 2f, 2f);
                        break;
                }
            
        }
    }

    

}
