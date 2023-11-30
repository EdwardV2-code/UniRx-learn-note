using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqAggregate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var ints = new List<int>() {2,3,4,5};

        int a = ints.Aggregate((sum, next) =>
        {
            return sum * next;
        });
        Debug.Log(a);

        int b = ints.Aggregate((min, next) =>
        {
            return min < next ? min : next;
        });
        Debug.Log(b);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}