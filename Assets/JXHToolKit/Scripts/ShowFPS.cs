﻿using UnityEngine;
using System.Collections;

public class ShowFPS : MonoBehaviour
{

    public int fontSize = 16;

    private float updateInterval = 0.1f;
    private float lastInterval;
    private int frames = 0;
    private float fps;
    private float time;

    private GUIStyle style;
    void Start()
    {
        style = new GUIStyle();
    }

    void OnGUI()
    {
        float rate = Screen.height / 640f;
        style.fontSize = (int)(fontSize * rate);
        style.normal.textColor = fps < 30f ? Color.red : Color.green;
        Rect rect = new Rect(10f * rate, (float)Screen.height - 50f, 100f * rate, 20f * rate);
        GUI.Label(rect, "fps " + fps.ToString("f2"), style);
    }

    void Update()
    {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = frames / (timeNow - lastInterval);
            time = 1000.0f / Mathf.Max(fps, 0.00001f);
            frames = 0;
            lastInterval = timeNow;
        }
    }

}
