using System;
using UniRx;
using UnityEngine;

public class RxTakeLast : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> s = new Subject<int>();
        s.TakeLast(2).Subscribe(x => Debug.Log(x));
        s.OnNext(1);
        s.OnNext(2);
        s.OnNext(3);
        s.OnCompleted();

        Subject<float> t = new Subject<float>();
        t.TakeLast(TimeSpan.FromSeconds(2)).Subscribe(x => Debug.Log(x));

        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => t.OnNext(Time.time));

        Observable.Timer(TimeSpan.FromSeconds(5))
            .Subscribe(_ => t.OnCompleted());
    }
}