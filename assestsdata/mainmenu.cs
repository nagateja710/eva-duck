using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    
    public static mainmenu instance;
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] players;

   private int index;
    public int Player
    {
        get { return index; }
        set { index = value; }
    }
  


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        
        else{ Destroy(gameObject);}
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += levelfinish;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= levelfinish;
    }

    void levelfinish(Scene scene,LoadSceneMode mode)
    {
        if (scene.name== zone.z[1])
        {
                Instantiate(players[index]);
          //  players[index].transform.position = new Vector3(0f, 0f, 0f);
        }
    }

}
