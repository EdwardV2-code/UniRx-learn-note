using System;
using UniRx;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1))
            .Subscribe(_ => Debug.Log("get message"));
    }
}