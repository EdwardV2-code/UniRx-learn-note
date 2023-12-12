using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TakeUntilDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ob = Observable.EveryUpdate()
            .ThrottleFirstFrame(100)
            .Select(frame =>
            {
                Debug.Log($"send message :{frame}");
                return frame;
            });
        ob.TakeUntilDisable(this)
           .Subscribe(frame => Debug.Log($"receive message :{frame}"));

        ob.Subscribe();
    }
}
