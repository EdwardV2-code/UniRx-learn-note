using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace UniRxLearning
{
    public class IntroExam : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            //
            Observable.EveryUpdate()                            //开启update时间监听，每次update都会触发
                .Where(_ => Input.GetMouseButtonDown(0))        //当满足条件时，才会触发下一步
                .First()                                        //只触发一次
                .Subscribe(_ => Debug.Log("Mouse Clicked!"));
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}