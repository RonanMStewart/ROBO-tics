using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Load : MonoBehaviour
{
    public GameObject player;
    public float x;
    public float y;
    public float z;
    public Timer timer;
    
    public void LoadGame() {
// gets saved x y z cordinates
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");
// creates vector than loads new position
        Vector3 posVec = new Vector3(x,y,z);
        player.transform.position = posVec;
// loads saved time remaining
        timer.TimeRemaining = PlayerPrefs.GetFloat("SavedTime");
        Debug.Log("Game data loaded!");
        }  
}
