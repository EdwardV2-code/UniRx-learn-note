using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqTakeWhile : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints = new List<int>() { 1, 3, 5, 2, 7, 6, 9 };
        ints.TakeWhile(x => x < 4)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}