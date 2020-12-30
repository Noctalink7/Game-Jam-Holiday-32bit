using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckKiller : MonoBehaviour
{
    public FloatValue health;
    private int life;
    public GameObject killerDuck;
    public GameObject bar;
    private int nextUpdate = 7;
    public Text score;
    public AudioSource hurt;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        life = 7;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
     //   Debug.Log(time);
        score.text = "Time survive : " + Mathf.FloorToInt(Time.time);
        if (Time.time >= nextUpdate)
        {
//            Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 7;
            killerDuck.transform.position = new Vector3(Random.Range(-23, 23), Random.Range(-4, 4), 0);
            GetComponent<AudioSource>().Play();
            loseHealth();
        }
        if (health.currentValue <= 0 || time > 20)
        {
            Debug.Log("Game over");
        }
    }

    void loseHealth()
    {
        health.currentValue -= 10;
    }

    void OnMouseDown()
    {
        life -= 1;
        hurt.Play();
        if (life == 0)
        {
            bar.transform.localScale = new Vector3(0, 1, 1);
            time = 0;
            life = 7;
        }
        nextUpdate += 1;
        killerDuck.transform.position = new Vector3(Random.Range(-23, 23), Random.Range(-4, 4), 0);
    }
}
