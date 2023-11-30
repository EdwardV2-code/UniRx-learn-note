using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqConcat : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints1 = new List<int>() { 1, 2, 3 };
        List<int> ints2 = new List<int>() { 5, 6, 7 };

        ints1.Concat(ints2)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}