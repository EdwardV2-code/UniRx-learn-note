using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
public class RxInterval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Observable.Interval(TimeSpan.FromSeconds(5))    //send a message every 5 seconds
        .Subscribe(_ =>                                 //subscribe to the message
        {
            // 在这里执行你想要的操作
            Debug.Log("5 seconds passed");
        })
        .AddTo(this);                                   //add the subscription to the GameObject's CompositeDisposable
                                                        //当monobehavior销毁同时取消订阅，防止内存泄漏
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
