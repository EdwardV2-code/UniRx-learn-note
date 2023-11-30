using System;
using UniRx;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> subject = new Subject<int>();

        subject.Delay(TimeSpan.FromSeconds(1))
            .Subscribe(x =>
            {
                if (x < 10)
                    subject.OnNext(++x);
                else
                    subject.OnCompleted();
            });

        subject.Sample(TimeSpan.FromSeconds(2))
            .Subscribe(x => Debug.Log("receive message :" + x));

        subject.OnNext(0);
    }
}
