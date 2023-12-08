using UniRx;
using UnityEngine;

public class IgnoreElements : MonoBehaviour
{
    private void Start()
    {
        Subject<int> subject = new Subject<int>();
        subject.Subscribe(x => Debug.Log("sub1 : " + x), () => Debug.Log($"sub1 : oncomplete"));
        var ig = subject.IgnoreElements();

        ig.Subscribe(x => Debug.Log($"sub2 : {x}"), () => Debug.Log($"sub2 : oncomplete"));

        subject.OnNext(0);
        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnCompleted();
    }
}