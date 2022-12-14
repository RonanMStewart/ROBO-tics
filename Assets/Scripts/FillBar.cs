using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FillBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed = .5f; 

    private float targetValue = 0;

    public Timer timer;

    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
    }

    public void loadScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetValue)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }

        if (slider.value == 1.0f)
        {
            timer.TimeOn = false;
            timer.TimerTxt.text = string.Format("Success");
            timer.TimerTxt.color = Color.green;
            loadScene(0);
        }
    }
    
    public void Increment (float newValue) {
       targetValue = slider.value += newValue;
    }
}
