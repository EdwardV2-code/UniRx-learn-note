using UniRx;
using UnityEngine;

public class DistinctUntilChange : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var left = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "left");

        var right = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Select(_ => "right");

        Observable.Merge(left, right)
            .DistinctUntilChanged()
            .Subscribe(x => Debug.Log(x));
    }
}