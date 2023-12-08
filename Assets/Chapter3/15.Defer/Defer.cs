using UniRx;
using UnityEngine;

public class Defer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var observable = Observable.Defer(() => Observable.Range(Random.Range(0, 3), Random.Range(4, 9)));

        observable.Subscribe(x => Debug.Log($"No1: {x} "));
        observable.Subscribe(x => Debug.Log($"No2: {x} "));
    }
}