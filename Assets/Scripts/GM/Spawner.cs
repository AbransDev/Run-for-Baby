using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform parent;
    public Collect cl;

    void Start()
    {   
        spawn();
    }

    void Update()
    {

     if(cl.reset == true)
     {
        spawn();
        cl.reset = false;
     }

    }

    
    public void spawn()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
