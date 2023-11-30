using UniRx;
using UnityEngine;

public class UniRxEmpty : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var e = Observable.Empty<string>();
        e.Subscribe(x => Debug.Log(x), () => Debug.Log("OnComplete"));
    }
}