using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthBar;
    public FloatValue health;

    // Start is called before the first frame update
    void Start()
    {
        health.currentValue = health.initialValue;
        healthBar.value = health.currentValue;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health.currentValue;
    }
}
