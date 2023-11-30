using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqGroupBy : MonoBehaviour
{
    public class Enemy
    {
        public enum Type
        {
            Boss, Strong, Weak
        }
        public Type type;
        public string name;
        public int hp;
    }
    // Start is called before the first frame update
    void Start()
    {
        List<Enemy> list = new List<Enemy>() 
        { 
            new Enemy() { type = Enemy.Type.Boss, name = "Boss1", hp = 100 },
            new Enemy() { type = Enemy.Type.Strong, name = "Strong1", hp = 50 },
            new Enemy() { type = Enemy.Type.Strong, name = "Strong2", hp = 50 },
            new Enemy() { type = Enemy.Type.Weak, name = "Weak1", hp = 10 },
            new Enemy() { type = Enemy.Type.Weak, name = "Weak2", hp = 10 },
            new Enemy() { type = Enemy.Type.Weak, name = "Weak3", hp = 10 },
        };

        list.GroupBy(x => x.type)
            .ToList()
            .ForEach(x => 
            {
                Debug.Log(x.Key);
                foreach (var item in x)
                {
                    Debug.Log(item.name);
                }
            });
    }

}
