using System;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    public TextMeshProUGUI text;
    TimeSpan time = TimeSpan.FromMinutes(3);
    GameObject[] finishObjects;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");
        Time.timeScale = 1;
        foreach(GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }

    public void Update()
    {
        var timeChange = TimeSpan.FromSeconds(Time.deltaTime);
        time -= timeChange;
        text.text = time.ToString(@"mm\:ss");

        if(time <= TimeSpan.FromSeconds(0))
        {
            Time.timeScale = 0;
            foreach(GameObject g in finishObjects)
            {
                g.SetActive(true);
            }
        }
    }
}
