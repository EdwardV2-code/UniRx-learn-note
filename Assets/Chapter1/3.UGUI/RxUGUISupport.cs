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
    public Text _Text;
    public InputField _InputField;
    public Slider _Slider;

    // Start is called before the first frame update
    private void Start()
    {
        _Button.OnClickAsObservable()
            .First()
            .Subscribe(_ => Debug.Log("Button is clicked"));

        _Toggle.OnValueChangedAsObservable()
            .Where(jiji => jiji)
            .Subscribe(isOn => Debug.Log("Toggle is " + (isOn ? "On" : "Off")));

        _Image.OnBeginDragAsObservable()
            .Subscribe(_ => Debug.Log("Begin Drag"));
        _Image.OnEndDragAsObservable()
            .Subscribe(_ => Debug.Log("End Drag"));

        UnityEvent e = new UnityEvent();
        e.AsObservable()
            .Subscribe(_ => Debug.Log("UnityEvent is called"));

        _Toggle.OnValueChangedAsObservable()
            .SubscribeToInteractable(_Button);  //ugui增强，当toggle的值改变时，button的interactable属性也会改变，interactable决定button能否点击

        _InputField.OnValueChangedAsObservable()
            .Where(x => x != null)
            .SubscribeToText(_Text);        //ugui增强，当inputfield的值改变时，text的值也会改变

        _Slider.OnValueChangedAsObservable()
            .SubscribeToText(_Text, x => x.ToString("F2"));  //ugui增强，当slider的值改变时，text的值也会改变，x => x.ToString("F2")是一个转换函数，将slider的值转换为string
    }
}