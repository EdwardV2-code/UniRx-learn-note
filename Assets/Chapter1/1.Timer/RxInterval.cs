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
            // ������ִ������Ҫ�Ĳ���
            Debug.Log("5 seconds passed");
        })
        .AddTo(this);                                   //add the subscription to the GameObject's CompositeDisposable
                                                        //��monobehavior����ͬʱȡ�����ģ���ֹ�ڴ�й©
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
