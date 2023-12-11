using UniRx;
using UnityEngine;

public class NextFrame : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(Time.frameCount);
        Observable.NextFrame()
            .Subscribe(_ => Debug.Log(Time.frameCount));
    }
}