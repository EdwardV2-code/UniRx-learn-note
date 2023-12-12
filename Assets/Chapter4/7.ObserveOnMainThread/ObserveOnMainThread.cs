using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ObserveOnMainThread : MonoBehaviour
{
    public Image _Image;
    // Start is called before the first frame update
    void Start()
    {
        Observable.Start(() => 
        {
            try
            {
                _Image.sprite = null;
                return true;
            }
            catch (System.Exception e)
            {
                Debug.LogErrorFormat(_Image, "Error: {0}", e.Message);
                return false;
            }
            
        }).ObserveOnMainThread()
        .Subscribe(result =>
        {
            Debug.Log(result);
            try
            {
                _Image.sprite = null;
            }
            catch (System.Exception e)
            {
                Debug.LogErrorFormat(_Image, "Error: {0}", e.Message);
            }
        });

        Observable.Start(() =>
        {

        }).SubscribeOnMainThread().Subscribe();
    }
}
