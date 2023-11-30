using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class RxSkip : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Skip(5)
            .Subscribe(Observable => Debug.Log("Clicked 5 times"));

        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Skip(TimeSpan.FromSeconds(5))
            .Subscribe(TimeSpan => Debug.Log("after 5 seconds"));
    }
}