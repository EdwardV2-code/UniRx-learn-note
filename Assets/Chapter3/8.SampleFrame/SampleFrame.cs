using UniRx;
using UnityEngine;

public class SampleFrame : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .SampleFrame(1000)
            .Subscribe(x => Debug.Log(x));
    }
}