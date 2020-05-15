using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepc : MonoBehaviour
{
    public int Lane=3;
    public float timer=0;
    public Vector3 Pstart;
    public Vector3 Pulo;
    public bool OnKick=false;
    public float Kicktime=1.1f;
    public float backCont = 1;
    public float sideCont = 1;
    public bool GO = false;
    // Start is called before the first frame update
    void Start()
    {
        Pstart = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKeyDown("left")&&Lane>1&&timer==0)
        {
            sideCont=-1;
            Lane--;
            OnKick = true;
        }
        if (Input.GetKeyDown("right")&&Lane<5 && timer == 0)
        {
           sideCont=1;
            Lane++;
            OnKick = true;
        }
        if (Input.GetKeyDown("space"))
        {
            
           
        }
        if (Lane > 5)
        {
            Lane = 5;
        }
        else if (Lane < 1)
        {
            Lane = 1;
        }
        if (OnKick)
        {
            timer = timer + Time.deltaTime;
            GetComponent<Rigidbody>().AddForce(new Vector3(Pulo.x*sideCont,Pulo.y*backCont,Pulo.z*backCont ), ForceMode.Force);
            if (timer>=Kicktime/2&& timer<Kicktime)
            {
                backCont = -1;
            }
            if (timer >= Kicktime)
            {

                backCont = 1;
                timer = 0;
                OnKick = false;

                }
        }
        if (GO)
        {
            Debug.Log("Gameover");
        }





    }

    }

