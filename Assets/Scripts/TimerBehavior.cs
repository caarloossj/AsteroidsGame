using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehavior : MonoBehaviour
{
    public float time;
    public float initialTime;
    public bool countDown;
    public UnityEvent<float> OnTime;
    public UnityEvent OnTimeOut;

    void Start()
    {
        restartTime();
    }

    void Update()
    {
        if(countDown)
        {
            time -= Time.deltaTime;
            if(time <= 0)
                OnTimeOut.Invoke();
        }
            
        else
            time += Time.deltaTime;
        OnTime.Invoke(time);
    }

    public void restartTime()
    {
        time = initialTime;
        OnTime.Invoke(time);
    }

    public void stopTime()
    {
        time = 0;
    }
}
