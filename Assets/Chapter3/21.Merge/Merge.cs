using UniRx;
using UnityEngine;

public class Merge : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var left = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_=>"left click");
        var right = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Select(_=>"right click");

        Observable.Merge(left,right)
            .Subscribe(x => Debug.Log(x));
    }
}