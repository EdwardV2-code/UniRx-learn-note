using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;

public class RxMVPEnemy : MonoBehaviour
{
    [SerializeField]
    public Enemy _Enemy;

    public Button _AttackBT;
    public Text _HPText;
    public Text _MPText;

    // Start is called before the first frame update
    private void Start()
    {
        _Enemy = new Enemy(200);
        _AttackBT.OnClickAsObservable()
            .Subscribe(_ =>
            {
                Debug.Log("Attack");
                _Enemy.HP.Value -= 66;
            });

        //_Enemy.HP.Subscribe(_ =>
        //{
        //    _HPText.text = _Enemy.HP.Value.ToString();
        //});
        _Enemy.HP.SubscribeToText(_HPText);

        _Enemy.IsDead.
            Where(b => b == true).  //当isdead为true
            Select(b => !b).        //对上面传来的message bool取反，IsDead不变
            Subscribe(x =>
            {
                Debug.Log($"params x = {x},IsDead = {_Enemy.IsDead}");
            });

        _Enemy.IsDead.
           Where(b => b == true).  //当isdead为true
           Select(b => !b).        //对上面传来的message bool取反，IsDead不变
           SubscribeToInteractable(_AttackBT);   //当enemydead，无法点击attack

        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Subscribe(_ => Debug.Log(_Enemy.HP.Value));
    }
}

[Serializable]
public class Enemy
{
    public ReactiveProperty<int> HP;
    public ReactiveProperty<int> MP;
    public IReadOnlyReactiveProperty<bool> IsDead;

    public Enemy(int hp)
    {
        this.HP = new ReactiveProperty<int>(hp);
        this.MP = new ReactiveProperty<int>(hp / 2);
        this.HP.Where(HP => HP <= 0).Select(HP => 0).Subscribe(hp => this.HP.Value = 0);
        this.IsDead = this.HP.Select(x => x <= 0).ToReactiveProperty();
        this.HP.Select(x => x / 2).Subscribe(MP => this.MP.Value = MP);
    }
}