using UniRx;
using UnityEngine;

public class DelayFrameSubscription : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int count = 0;
        Subject<int> delay = new Subject<int>();
        var ob = Observable.Interval(System.TimeSpan.FromSeconds(1)).
            Subscribe(_=> delay.OnNext(count++));

        delay.DelayFrameSubscription(1000)
        .Subscribe(time => Debug.LogFormat("DelayFrame Log: {0}", time));

        delay.Subscribe(time => Debug.LogFormat("Normal Log: {0}", time));
    }
}