using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    Action<int> del;
    //delegate void NumDelegate(int num);
    //NumDelegate del;

    private void Start()
    {
        del = FirstPlus;
        del(5);

        del = SecondPlus;
        del(10);
    }


    void FirstPlus(int num)
    {
        int result = num * num;
        $"FistPlus : {result}".Log();
    }

    void SecondPlus(int num)
    {
        int result = num * num;
        $"Second Plus : {result}".Log();
    }
}
