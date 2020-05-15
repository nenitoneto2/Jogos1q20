using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float timer;
    public float Spawtime=3;
    public int sorte;
    public int espaco;
    public bool Parede,Decora;
    public GameObject pilar,decor ;
    // Start is called before the first frame update
    void Start()
    {
        Parede = false;
        Decora = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        sorte =Random.Range(1, 20);
        espaco = Random.Range(-2,3);
        if (sorte <= 3&&timer>=Spawtime)
        {
            Parede = true;
            Instantiate(pilar, new Vector3(5*espaco, transform.position.y + 12.5f, transform.position.z), transform.rotation, transform);


            timer = 0;
            Parede = false;
        }
        else if (sorte >=4 && sorte<=7 && timer >= Spawtime)
        {
            Decora = true;
            Instantiate(decor, new Vector3(5 * espaco, transform.position.y, transform.position.z), transform.rotation, transform);

            timer = 0;
            Decora = false;
        }
        
        else
        {

        }
        
    }
}
