using System;
using UniRx;
using UnityEngine;

public class RefCount : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var observable = Observable.Interval(System.TimeSpan.FromSeconds(1f))
            .Do(value => Debug.Log($"Publishing {value}"))
            .Publish()
            .RefCount();

        var o1 = observable.Subscribe(observable => Debug.Log($"FirstSub: {observable}"));

        IDisposable o2 = null;
        Observable.Timer(System.TimeSpan.FromSeconds(2))
            .Do(_ => o2 = observable.Subscribe(observable => Debug.Log($"SecondSub: {observable}")))
            .Delay(System.TimeSpan.FromSeconds(2))
            .Do(_ =>
            {
                o1.Dispose();
            })
            .Delay(System.TimeSpan.FromSeconds(2))
            .Do(_ =>
            {
                o2.Dispose();
            })
            .Subscribe();
    }
}