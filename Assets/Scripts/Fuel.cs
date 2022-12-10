using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour
{
    [SerializeField] GameObject prompt;
    public LoadSceneMode LoadSceneMode = LoadSceneMode.Additive;

    public void OnTriggerEnter(Collider other) {
        prompt.SetActive(true);
    }

    public void OnTriggerExit(Collider other) {
        prompt.SetActive(false);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(6);
        }
    }
}
