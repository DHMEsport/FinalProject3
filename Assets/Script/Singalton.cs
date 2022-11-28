using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singalton<T> : MonoBehaviour where T :Singalton<T>
{
    private static T _instance;
    public static T instance => _instance;

    protected virtual void Awake()
    {
        _instance = this as T;
    }
}
