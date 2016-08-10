//
// BlinkEffect.cs
//
// Author:
// [Jiangxh]
//
// Copyright (C) 919575700@qq.com

using UnityEngine;
using System.Collections;

public class BlinkEffect : MonoBehaviour
{
    // 是否打开闪烁
    public bool isOpen;
    // 闪烁的间隔
    public int interval = 20;
    // 闪烁交替的不同颜色材质
    public Material Material1;
    public Material Material2;

    // 闪烁计时器
    private int timer = 0;
    // 取得渲染器引用
    private Renderer render;

    // Use this for initialization
    void Start()
    {
        // 默认关闭闪烁
        isOpen = false;
        // 取得渲染器组件
        this.render = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen) return;
        // 交替变换材质
        if (timer <= interval)
        {
            this.render.material = Material1;
        }
        else
        {
            this.render.material = Material2;
        }
        if (timer >= 2 * interval)
        {
            timer = 0;
        }
        //计时器递增    
        timer++;
    }
}
