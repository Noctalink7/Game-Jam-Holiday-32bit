using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckKiller : MonoBehaviour
{
    public FloatValue health;
    private int life;
    public GameObject killerDuck;
    public GameObject bar;
    private int nextUpdate = 10;

    // Start is called before the first frame update
    void Start()
    {
        life = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 10;
            loseHealth();
        }
    }

    void loseHealth()
    {
        health.currentValue -= 5;
    }

    void OnMouseDown()
    {
        life -= 1;
        if (life == 0)
        {
            bar.transform.localScale = new Vector3(0, 1, 1);
            life = 10;
        }
        nextUpdate = Mathf.FloorToInt(Time.time) + 1;
        killerDuck.transform.position = new Vector3(Random.Range(-23, 23), Random.Range(-4, 4), 0);
    }
}
