using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class DelayFrame : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Time.frameCount);
        Observable.ReturnUnit()
            .Do(_=>Debug.Log(Time.frameCount))
            .DelayFrame(10)
            .Subscribe(_ => Debug.Log(Time.frameCount));
    }
}
