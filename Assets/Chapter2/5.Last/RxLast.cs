using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxLast : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Create<int>(a =>
        {
            a.OnNext(1);
            a.OnNext(2);
            a.OnNext(3);
            a.OnNext(4);
            a.OnNext(5);
            a.OnCompleted();
            return Disposable.Empty;
        }).Last().Subscribe(x => Debug.Log(x));

        Observable.Create<int>(a =>
        {
            a.OnNext(1);
            a.OnNext(2);
            a.OnNext(3);
            a.OnNext(4);
            a.OnNext(5);
            a.OnCompleted();
            return Disposable.Empty;
        }).Last(x => x < 3).Subscribe(x => Debug.Log(x));
    }
}