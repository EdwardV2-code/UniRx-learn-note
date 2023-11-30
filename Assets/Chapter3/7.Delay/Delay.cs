using System;
using UniRx;
using UnityEngine;

public class Delay : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Delay(System.TimeSpan.FromSeconds(3))
            .Subscribe(_ => Debug.Log("Clicked after 3 seconds"));

        Observable.Timer(TimeSpan.FromSeconds(1))
            .Select(_ =>
            {
                Debug.Log("A");
                return _;
            })
            .Delay(TimeSpan.FromSeconds(0.5f))
            .Select(_ =>
            {
                Debug.Log("B");
                return _; 
            })
            .Delay(TimeSpan.FromSeconds(0.5f))
            .Select(_ =>
            {
                Debug.Log("C");
                return _; 
            })
             .Delay(TimeSpan.FromSeconds(0.5f))
             .Subscribe();
    }
}