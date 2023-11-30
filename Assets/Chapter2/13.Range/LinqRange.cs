using System.Linq;
using UnityEngine;

public class LinqRange : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Enumerable.Range(1, 10).Take(5)
            .Select(x => x = x + x)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}