using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class FrameTimeInterval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .FrameTimeInterval()
            .TimeInterval()
            .Subscribe(frameTimeInterval => Debug.Log($"TimeInterval:{frameTimeInterval.Interval}   FrameTimeInterval: {frameTimeInterval.Value.Interval}"));
    }
}
