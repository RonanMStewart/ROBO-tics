using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour 
{

    public GameObject player;
    public float x;
    public float y;
    public float z;
    public Timer timer;

   public void CreateSave() {
// sets player position 
        x = player.transform.position.x;
        PlayerPrefs.SetFloat("x", x);
        y = player.transform.position.y;
        PlayerPrefs.SetFloat("y", y);
        z = player.transform.position.z;
        PlayerPrefs.SetFloat("z", z);
//sets time
        PlayerPrefs.SetFloat("SavedTime", timer.TimeRemaining);
//Creates save
        PlayerPrefs.Save();
	    Debug.Log("Game data saved! " + timer.TimeRemaining);
        }

    
   
}
