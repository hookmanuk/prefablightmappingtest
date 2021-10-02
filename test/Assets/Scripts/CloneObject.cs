using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject ToClone;

    // Start is called before the first frame update
    void Start()
    {
        var obj = Instantiate(ToClone);

        obj.transform.position = obj.transform.position + new Vector3(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
