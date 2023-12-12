using UniRx;
using UnityEngine;

public class TimeoutFrame : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .TimeoutFrame(1000)
            .Subscribe(frame => Debug.Log(frame), error => Debug.LogError("Timeout " + error.Message), () => Debug.Log("Completed"));
    }
}