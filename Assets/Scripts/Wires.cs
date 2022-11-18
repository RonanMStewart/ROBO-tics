using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{

    bool isFollowing = false;
    bool isConnected = false;
    Vector3 startPos;

    void Start() {
        startPos = transform.position;
    }

    public void toggleFollow() {
        isFollowing = !isFollowing;
        if(!isConnected) {
            transform.position = startPos;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if(isFollowing && !isConnected){
            transform.position = Input.mousePosition;
        }
    }

    public bool checkConnection() {
        return true;
    }

    public void connect() {
        if(checkConnection()){
            isConnected=true;
            enabled=false;
        }
    }
}
