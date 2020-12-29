using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBar : MonoBehaviour
{

    public GameObject bar;
//    public int time;
    private Vector3 scaleChange;
    private int nextUpdate = 1;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.01f, 0, 0);
        //AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            AnimateBar();
        }
    }

    public void AnimateBar()
    {
      //LeanTween.scaleX(bar, 1, time);
      bar.transform.localScale += scaleChange;
    }
}
