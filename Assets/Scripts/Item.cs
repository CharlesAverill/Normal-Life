using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    bool beginning_scale_fix;
    public Transform cam;
    public Transform initial_parent;
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.parent = cam;
        beginning_scale_fix = true;
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(transform.parent);
      if(transform.parent == cam && beginning_scale_fix){
        GetComponent<Rigidbody>().useGravity = true;
        transform.parent = null;
        beginning_scale_fix = false;
      }
    }
}
