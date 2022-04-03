using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Origin : MonoBehaviour
{
    public static Action origin;

    private void Awake()
    {
        origin = () => { Mission(); };
    }
    public void Mission()
    {
        Debug.Log("Mission Complete");
    }
}
