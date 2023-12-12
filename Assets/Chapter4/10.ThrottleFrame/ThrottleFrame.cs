using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ThrottleFrame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButton(0))
            .ThrottleFrame(1000)
            .Subscribe(frame => Debug.Log(frame));
    }
}
