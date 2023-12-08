using UniRx;
using UnityEngine;

public class COmbineLatest : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int left = 0;
        int right = 0;
        var stream1 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => left++);
        var stream2 = Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Select(_ => right++);

        stream1.CombineLatest(stream2, (i, j) => $"{i}  {j}")
            .Subscribe(_ => Debug.Log("Left: " + left + " Right: " + right));
    }
}