using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    private int second = 1;
    private float starTime;

    // Start is called before the first frame update
    void Start()
    {
        life = 7;
        time = 0;
        starTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time-starTime >= second) {
            time += 1;
       //     Debug.Log(time);
            second = Mathf.FloorToInt(Time.time - starTime) + 1;
        }
        score.text = "Time survive : " + Mathf.FloorToInt(Time.time - starTime);
        if (Time.time - starTime >= nextUpdate)
        {
//            Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time - starTime) + 7;
            killerDuck.transform.position = new Vector3(Random.Range(-23, 23), Random.Range(-4, 4), 0);
            GetComponent<AudioSource>().Play();
            loseHealth();
        }
        if (health.currentValue <= 0 || time > 20)
        {
            SceneManager.LoadScene("gameover");
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
