using UniRx;
using UnityEngine;

public class DelaySubscription : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int count = 0;
        Observable.Interval(System.TimeSpan.FromSeconds(1))
            .Select(_=> count++)
            .Take(5)
            .DelaySubscription(System.TimeSpan.FromSeconds(3))
            .Subscribe(t => Debug.Log(t));
    }
}