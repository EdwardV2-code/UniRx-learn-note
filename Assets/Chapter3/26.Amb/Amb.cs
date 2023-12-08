using UniRx;
using UnityEngine;

public class Amb : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var ob1 = Observable.EveryUpdate()
            .Delay(System.TimeSpan.FromSeconds(1))
            .Take(3)
            .Select(_ => "1s");
        var ob2 = Observable.EveryUpdate()
            .Delay(System.TimeSpan.FromSeconds(2))
             .Take(3)
            .Select(_ => "2s");
        var ob3 = Observable.EveryUpdate()
            .Delay(System.TimeSpan.FromSeconds(3))
             .Take(3)
            .Select(_ => "3s");

        Observable.Amb(ob1, ob2, ob3)
            .Subscribe(x => Debug.Log(x));
    }
}