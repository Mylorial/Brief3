using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventBus : MonoBehaviour
{
    // Make it static so it can be Access anywhere
    private static EventBus _current;

    public static EventBus Current { get { return _current; } }

    // looks to see if theres not already a event bus if there is it Destroy itself
    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public event Action Switch;

    public void Switchtrigger()
    {
        Switch();
    }
}