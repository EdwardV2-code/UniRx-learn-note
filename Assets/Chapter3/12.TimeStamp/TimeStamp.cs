using UniRx;
using UnityEngine;

public class TimeStamp : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "Get MouseButtonDown")
            .Timestamp()
            .Subscribe(x => Debug.Log($"time = {x.Timestamp} message = {x.Value}"));
    }
}