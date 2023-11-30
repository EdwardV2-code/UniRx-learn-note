using UniRx;
using UnityEngine;

public class TimeInterval : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .TimeInterval()
            .Subscribe(x => Debug.Log(x));
    }
}