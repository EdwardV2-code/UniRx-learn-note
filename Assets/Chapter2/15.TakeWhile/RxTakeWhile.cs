using UniRx;
using UnityEngine;

public class RxTakeWhile : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .TakeWhile((_, num) => { return !Input.GetMouseButtonDown(0) && num < 100; })
            .Subscribe(_ => Debug.Log("Mouse not clicked"));
    }
}