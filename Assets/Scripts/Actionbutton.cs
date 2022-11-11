using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionbutton : MonoBehaviour
{
        ParticleSystem myParticleSystem;

    private 
    // Start is called before the first frame update
    void Start()
    {
              myParticleSystem = GetComponentInChildren<ParticleSystem>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
        transform.Rotate(0, 0, -90f, Space.Self);
        myParticleSystem.Play();
        }

        if (Input.GetButtonUp("Fire1"))
        {
        transform.Rotate(0, 0, 90f, Space.Self); 
        myParticleSystem.Stop();
        }
    }
}
