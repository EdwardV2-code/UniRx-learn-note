using UniRx;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var s1 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "Mouse Left Button Down");

        var s2 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonUp(0))
            .Select(_ => "Mouse Left Button Up");

        var s = Observable.Return(1);
        s.Select(_ => s1)
        .Switch()
        .Take(System.TimeSpan.FromSeconds(5))
        .Subscribe(x => Debug.Log(x), () =>
        {
            s.Select(_ => s2)
            .Switch()
            .Take(System.TimeSpan.FromSeconds(5))
            .Subscribe(y => Debug.Log(y));
        });
    }
}