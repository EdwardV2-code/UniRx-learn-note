using UniRx;
using UnityEngine;

public class BatchFrame : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .BatchFrame(2000, FrameCountType.EndOfFrame)
            .Subscribe(BatchFrame => Debug.Log(BatchFrame.Count));
    }
}