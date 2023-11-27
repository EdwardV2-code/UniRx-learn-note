using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class RxUGUISupport : MonoBehaviour
{
    public Button _Button;
    public Toggle _Toggle;
    public Image _Image;
    // Start is called before the first frame update
    void Start()
    {
        _Button.OnClickAsObservable()
            .First()
            .Subscribe(_ => Debug.Log("Button is clicked"));

        _Toggle.OnValueChangedAsObservable()
            .Where(jiji => jiji)
            .Subscribe(isOn => Debug.Log("Toggle is " + (isOn ? "On" : "Off")));

        _Image.OnBeginDragAsObservable()
            .Subscribe(_=> Debug.Log("Begin Drag"));
        _Image.OnEndDragAsObservable()
            .Subscribe(_ => Debug.Log("End Drag"));

        UnityEvent e = new UnityEvent();
        e.AsObservable()
            .Subscribe(_ => Debug.Log("UnityEvent is called"));
    }
}
