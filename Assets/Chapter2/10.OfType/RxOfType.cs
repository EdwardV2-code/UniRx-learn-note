using UniRx;
using UnityEngine;

public class RxOfType : MonoBehaviour
{
    public class Enemy
    { public string name; }

    public class MidBoss : Enemy
    { }

    public class BigBoss : Enemy
    { }

    public class Boss : Enemy
    { }

    // Start is called before the first frame update
    private void Start()
    {
        Subject<Enemy> subject = new Subject<Enemy>();

        subject.OfType<Enemy, Boss>()
            .Subscribe(subject => Debug.Log("Boss: " + subject.name));
         

        subject.OnNext(new MidBoss() { name = "A" });
        subject.OnNext(new BigBoss() { name = "B" });
        subject.OnNext(new Boss() { name = "C" });

        subject.OnCompleted();  // ÷∂ØΩ· ¯
    }
}
