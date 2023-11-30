using UniRx;
using UnityEngine;

public class RxToList : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<float> subject = new Subject<float>();
        subject.ToList()
            .Subscribe(x =>
            {
                foreach (var item in x)
                {
                    Debug.Log(item);
                }
            });

        Observable.Interval(System.TimeSpan.FromSeconds(1))
            .Take(5)
            .Subscribe(_=>subject.OnNext(Time.time),()=> subject.OnCompleted());

    }
}