using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ThrottleFirstFrame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .ThrottleFirstFrame(1000)
            .Subscribe(_ => Debug.LogFormat("ThrottleFirstFrame Log: {0}", Time.frameCount));
    }
}
