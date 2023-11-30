using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .First()
            .Repeat()
            .Subscribe(Observable => Debug.Log("Clicked"));

        Observable.Timer(TimeSpan.FromSeconds(1))
            .Repeat()
            .Subscribe(_ => Debug.Log("1 second passed"));
    }
}
