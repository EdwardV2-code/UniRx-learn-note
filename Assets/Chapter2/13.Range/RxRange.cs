using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxRange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(1, 10)
            .Take(5)
            .Subscribe(x => Debug.Log(x + x));
    }
}
