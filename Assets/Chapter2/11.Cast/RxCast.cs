using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxCast : MonoBehaviour
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
    void Start()
    {
        Subject<Enemy> subject = new Subject<Enemy>();
        subject.Cast<Enemy, Boss>()
            .Subscribe(subject => Debug.Log("Boss: " + subject.name));

        //subject.OnNext(new MidBoss() { name = "A" });
        //subject.OnNext(new BigBoss() { name = "B" });
        subject.OnNext(new Boss() { name = "C" });

    }
}
