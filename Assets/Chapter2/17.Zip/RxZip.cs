using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxZip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var stream1 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0));
        var stream2 = Observable.EveryUpdate()
            .Where(_=> Input.GetMouseButtonDown(1));

        stream1.Zip(stream2,(r,l)=>"Pair")
            .Subscribe(x => Debug.Log(x));
    }
}

