using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RepeatUntilDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Subject<int> sub = new Subject<int>();
        sub.RepeatUntilDestroy(this)
            
            .Subscribe(x => Debug.Log(x));
        sub.OnNext(1);
        sub.OnNext(2);
        sub.OnNext(3);
        sub.OnCompleted();
    }
}
