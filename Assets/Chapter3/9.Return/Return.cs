using UniRx;
using UnityEngine;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Return(1)
            .Subscribe(x => Debug.Log(x), () => Debug.Log("Complete"));
    }
}