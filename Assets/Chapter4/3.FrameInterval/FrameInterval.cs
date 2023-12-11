using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class FrameInterval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Timestamp()
            .FrameInterval()
            .Subscribe(interval => Debug.Log($"interval:{interval.Interval}  timestamp:{interval.Value.Timestamp} value:{interval.Value.Value}"));
    }
}
