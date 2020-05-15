using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveparalax : MonoBehaviour
{
    public float runner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z <-320)
        {
            transform.position = new Vector3(0f, 0f, 620f);

        }
        GetComponent<Rigidbody>().velocity = new Vector3 (0f,0f,-runner);
        runner=Time.realtimeSinceStartup;
    }

    
}
