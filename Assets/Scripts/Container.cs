using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    private float speed = 2f;
    public FillBar FB;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other) {
        speed = speed * -1;
    }


    private void OnParticleCollision(GameObject other) 
    {
        {
        FB.Increment(0.10f);
        } 
    }
}
