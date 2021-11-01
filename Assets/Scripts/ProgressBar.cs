using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public float FillSpeed = 0.5f;
    public static float targetProgress;
    
    public void Awake(){
        slider = gameObject.GetComponent<Slider>();
    }

    void Update(){
        if(slider.value < targetProgress)
        slider.value += FillSpeed * Time.deltaTime;
    }
    public void IncrementProgress(float newProgress){
        targetProgress = slider.value + newProgress;
    }
}
