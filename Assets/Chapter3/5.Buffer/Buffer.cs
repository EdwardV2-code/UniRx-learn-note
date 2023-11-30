using UniRx;
using UnityEngine;

public class Buffer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Buffer(3)
            .Subscribe(Buffer => Debug.Log(Buffer.Count));

        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Buffer(System.TimeSpan.FromSeconds(5))
            .Subscribe(buffer => Debug.Log(buffer.Count));
    }
}