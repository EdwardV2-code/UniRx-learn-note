using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LinqCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList list = new ArrayList() { 1,2,3,4,5,6 };
        list.Cast<int>().ToList().ForEach(x => Debug.Log(x));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
