using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontua : MonoBehaviour
{
    public int Pontos,combo;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        Pontos = 0;
        combo = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Aumenta ()
    {
        Pontos = Pontos + (100 * combo);
    }
    public void Comboup()
    {
        combo = combo+1;
    }
    public void Comboreset()
    {

    }
}
