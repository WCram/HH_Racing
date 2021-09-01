using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Pad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("This works");
            other.gameObject.GetComponent<Rigidbody>().mass = 25000;
        }
    }
}
