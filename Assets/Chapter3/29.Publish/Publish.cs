using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Publish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var times = Observable.Interval(System.TimeSpan.FromSeconds(1)).Publish();
        times.Subscribe(times => Debug.Log("First: " + times));
        Observable.Timer(System.TimeSpan.FromSeconds(3))
            .Subscribe(_ => times.Connect());
    }
}
