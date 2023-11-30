using UniRx;
using UnityEngine;

public class ThrottleFirst : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int i = 0;
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => $"Get MouseButtonDown {i++}")
            .ThrottleFirst(System.TimeSpan.FromSeconds(5))
            .Subscribe(x => Debug.Log(x));
    }
}