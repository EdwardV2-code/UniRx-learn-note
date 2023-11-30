using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSkip : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints = Enumerable.Range(1, 10).ToList();
        ints.Skip(5)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}