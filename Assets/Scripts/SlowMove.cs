using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMove : MonoBehaviour
{
    public GameObject GameObject;
    public Vector3 targetPosition;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = targetPosition - gameObject.transform.position;
        float distance = direction.magnitude;
        if(distance >0){
            gameObject.transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
}