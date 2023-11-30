using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxTake : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(Observable => Input.GetMouseButtonDown(0))
            .Take(3)
            .Select(_ => "Clicked")
            .Subscribe(x => Debug.Log(x));

        Observable.EveryUpdate()
            .Where(Observable => Input.GetMouseButtonDown(1))
            .Take(TimeSpan.FromSeconds(5))
            .Select(_ => "Clicked")
            .Subscribe(x => Debug.Log(x));
    }
}