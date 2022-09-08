using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjective : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(20, transform.position.y, transform.position.z), 5 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2.5f, 5), transform.position.y, transform.position.z);
    }
}
