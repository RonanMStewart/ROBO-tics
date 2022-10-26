using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensX;
    public float sensy;

    public Transform orientation; 

    float xRotate;
    float yRotate;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float getX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float getY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensy;
        
        yRotate += getX;

        xRotate -= getY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        orientation.rotation = Quaternion.Euler(0,yRotate,0);
    }
}
