using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed = .5f; 

    private float targetValue = 0;

    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
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
    }
    
    public void Increment (float newValue) {
       targetValue = slider.value += newValue;
    }
}
