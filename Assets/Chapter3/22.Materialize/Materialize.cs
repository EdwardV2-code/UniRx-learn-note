using UniRx;
using UnityEngine;

public class Materialize : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> subject = new Subject<int>();
        subject.Subscribe(x => Debug.Log(x));
        var exception = subject.Materialize()
            .Where(x => x.Exception != null)
            .Dematerialize();

        var completed = subject.Materialize()
            .Where(x => x.Kind == NotificationKind.OnCompleted)
            .Dematerialize();

        exception.Subscribe(_ => Debug.Log("Exception!"));
        completed.Subscribe(_ => Debug.Log("Completed!"));

        subject.OnNext(0);
        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnError(new System.Exception("error!"));
        subject.OnNext(3);
        subject.OnCompleted();
    }
}