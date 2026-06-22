using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecurityBar : MonoBehaviour
{
    [SerializeField] public Slider slider;
    [SerializeField] public Gradient gradient;
    [SerializeField] public Image fill;
    [SerializeField] private GameManager gm;

    void Start()
    {
        slider.maxValue = 100;
        slider.value = gm.SecurityLvl;
    }
    void Update()
    {
        slider.value = gm.SecurityLvl;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
