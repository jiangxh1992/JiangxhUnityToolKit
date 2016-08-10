//
// DontDestroyThis.cs
//
// Author:
// [Jiangxh]
//
// Copyright (C) 919575700@qq.com

using UnityEngine;
using System.Collections;

namespace Game
{
    public class DontDestroyThis : MonoBehaviour
    {
        void Awake()
        {
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }
}
