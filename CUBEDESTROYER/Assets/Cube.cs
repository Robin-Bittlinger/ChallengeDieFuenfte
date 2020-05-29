using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int cashmoney = 50;
    [HideInInspector]
    public float deadline = 1f;
    public static float minLive = 1f;
    public static float maxLive = 3f;

    void Update()
    {
        deadlineTimer();
    }

    void deadlineTimer()
    {
        deadline -= Time.deltaTime;

        if (deadline < 0)
        {
            destroySelf();
        }

    }

    public void destroySelf()
    {
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        Destroy(this.gameObject);
    }
}
