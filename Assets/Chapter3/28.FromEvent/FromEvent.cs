using System;
using UniRx;
using UnityEngine;

public class FromEvent : MonoBehaviour
{
    private event Action action;

    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => action?.Invoke());

        Observable.FromEvent(a => action += a, a => action -= a)
            .Subscribe(_ => Debug.Log("Mouse clicked"));
    }
}