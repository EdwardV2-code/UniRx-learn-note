using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqZip : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints = Enumerable.Range(0, 10).ToList();
        List<string> strings = new List<string> { "zero", "one", "two", "three", "four", "five" };

        ints.Zip(strings, (i, s) =>
        {
            string result = $"{i}:{s}";
            return result;
        }).ToList()
        .ForEach(x => Debug.Log(x));
    }
}