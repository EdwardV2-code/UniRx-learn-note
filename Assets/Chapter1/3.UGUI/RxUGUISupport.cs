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
            .SubscribeToInteractable(_Button);  //ugui��ǿ����toggle��ֵ�ı�ʱ��button��interactable����Ҳ��ı䣬interactable����button�ܷ���

        _InputField.OnValueChangedAsObservable()
            .Where(x => x != null)
            .SubscribeToText(_Text);        //ugui��ǿ����inputfield��ֵ�ı�ʱ��text��ֵҲ��ı�

        _Slider.OnValueChangedAsObservable()
            .SubscribeToText(_Text, x => x.ToString("F2"));  //ugui��ǿ����slider��ֵ�ı�ʱ��text��ֵҲ��ı䣬x => x.ToString("F2")��һ��ת����������slider��ֵת��Ϊstring
    }
}