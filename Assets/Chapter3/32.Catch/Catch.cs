using UniRx;
using UnityEngine;

public class Catch : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var errorObs = Observable.Throw<string>(new System.Exception("Get Error"))
            .Catch<string, System.Exception>(e =>
            {
                Debug.Log(e.Message);
                return Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "Get mouse button down");
            })
            .Subscribe(value => Debug.Log(value));
    }
}