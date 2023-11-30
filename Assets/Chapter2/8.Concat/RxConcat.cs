using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxConcat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var stream1 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButton(0))
            .Take(3)
            .Select(_=> 0)
            ;
        var stream2 = Model.Instance._TestInt.AsObservable().Take(2);

        var s = stream2.Concat(stream1)
            .Subscribe(_ => Debug.Log("get message"));
    }
}
