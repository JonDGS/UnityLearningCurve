using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = GameObject.Find("SmartTV");
        transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position); 

    }
}
