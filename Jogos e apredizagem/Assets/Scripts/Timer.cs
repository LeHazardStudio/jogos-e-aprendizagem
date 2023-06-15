using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Timer : MonoBehaviour
{
    public static float Tempo;

    public Timer(float set)
    {
        Tempo = set;
    }

    public float getTimer()
    {
        return (Tempo);
    }

    public void countDown()
    {
        Tempo -= Time.deltaTime;
    }
}
