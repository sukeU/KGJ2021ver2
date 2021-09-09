using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AudioMixer : MonoBehaviour
{
    Slider Slider;
    void Awake()
    {
        Slider = GetComponent<Slider>();
        Slider.value = AudioListener.volume;
    }
    private void OnEnable()
    {
        Slider.value = AudioListener.volume;
        Slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);
    }

    private void OnDisable()
    {
        Slider.onValueChanged.RemoveAllListeners();
    }

  
}
