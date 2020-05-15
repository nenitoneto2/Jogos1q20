using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedecor : MonoBehaviour
{
    // Start is called before the first frame update
    public float runner;
    public bool pass = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -runner);
        runner = Time.realtimeSinceStartup;

        if (GetComponent<Transform>().position.z <= -30)
        {
            pass = true;
            Destroy(this.gameObject);


        }
        //  GetComponentInParent<Pontua>
    }

    private void OnDestroy()
    {
        if (pass)
        {

            GetComponentInParent<Pontua>().Aumenta();
        }
    
    }
}
