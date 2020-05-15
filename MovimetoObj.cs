using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimetoObj : MonoBehaviour
{
    public float runner;
    public bool pass=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -runner);
        runner = Time.realtimeSinceStartup;
        
        if(GetComponent<Transform>().position.z<=-30)
        {
            pass = true;
            Destroy(this.gameObject);
            
            
        }
      //  GetComponentInParent<Pontua>
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            if (collision.gameObject.GetComponent<movepc>().OnKick)
            {
                pass = false;
                Destroy(this.gameObject);
            }
            else
            {
                collision.gameObject.GetComponent<movepc>().GO = true;
            }
        }
    }
    private void OnDestroy()
    {
        if(pass)
        {
           
            GetComponentInParent<Pontua>().Aumenta();
        }
        else
        {
            
            GetComponentInParent<Pontua>().Comboup();
            GetComponentInParent<Pontua>().Aumenta();
        }
    }
}
