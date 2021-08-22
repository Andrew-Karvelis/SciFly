using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GM : MonoBehaviour {
    //public int zScenePos = 4;
    public Transform platform;
    public static bool spawn;
    public GameObject spawnPos;
    //public Transform coinObj;
    //public Transform obstObj;
    //public Transform capsuleObj;
    //public int randNum;

    // Use this for initialization
    void Start () {
        //Instantiate(platform, new Vector3(0, 0, 4), platform.rotation);
        //Instantiate(platform, new Vector3(0, 0, 8), platform.rotation);
        spawn = true;
    }
    private void Update()
    {
        if (spawn == true)
        {
            Instantiate(platform, spawnPos.transform.position, platform.rotation);
            spawn = false;
        }
        Debug.Log(spawn);
    
        //if (zScenePos < 120)
        //{
            
        //    zScenePos += 4;

        //}

    }
      
}
