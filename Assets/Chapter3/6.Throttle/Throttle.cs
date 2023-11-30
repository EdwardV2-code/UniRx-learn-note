using UniRx;
using UnityEngine;

public class Throttle : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Throttle(System.TimeSpan.FromSeconds(5))
            .Subscribe(_ => Debug.Log("Get Message"));
    }
}