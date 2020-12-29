using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LoseLifeTmp : MonoBehaviour
{
    public FloatValue health;

    void OnMouseDown()
    {
        health.currentValue -= 10;
    }
}
