using UniRx;
using UnityEngine;

public class StartWith : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var stream = Observable.Return<string>("World")
            .StartWith("Hello")
            .Aggregate((x, y) => $"{x} {y}")
            .Subscribe(x => Debug.Log(x));
    }
}