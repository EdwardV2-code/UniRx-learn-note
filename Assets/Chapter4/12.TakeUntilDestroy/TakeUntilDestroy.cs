using UniRx;
using UnityEngine;

public class TakeUntilDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .ThrottleFirstFrame(100)
            .TakeUntilDestroy(this)
            .Subscribe(frame => Debug.Log(frame));

        Observable.TimerFrame(1000)
            .Subscribe(_ =>
            {
                Debug.Log("Destroy");
                Destroy(this.gameObject);
            });
    }
}