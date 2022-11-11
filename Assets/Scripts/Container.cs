using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public FillBar FB;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnParticleCollision(GameObject other) 
    {
        {
        FB.Increment(0.10f);
        } 
    }
}
