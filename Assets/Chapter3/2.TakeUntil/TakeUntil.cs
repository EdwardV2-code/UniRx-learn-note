using UniRx;
using UnityEngine;

public class TakeUntil : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Interval(System.TimeSpan.FromSeconds(1))
            .TakeUntil(Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)))
            .Subscribe(x => Debug.Log(x));
    }
}