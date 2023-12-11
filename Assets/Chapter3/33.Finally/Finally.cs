using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Finally : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Take(5)
            .Finally(() =>
            {
                Debug.Log("finally");
            }).
            Subscribe(_ => Debug.Log("get mouse down"), () => Debug.Log("complete"));
    }
}
