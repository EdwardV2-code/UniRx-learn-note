using UniRx;
using UnityEngine;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var replayObs = Observable.Interval(System.TimeSpan.FromSeconds(1))
            .Do(x => Debug.Log("Interval: " + x))
            .Replay();

        replayObs.Subscribe(x => Debug.Log("Subscribe 1: " + x));
        replayObs.Connect();

        Observable.Timer(System.TimeSpan.FromSeconds(2))
            .Subscribe(_ => replayObs.Subscribe(x => Debug.Log("Subscribe 2: " + x)));
    }
}