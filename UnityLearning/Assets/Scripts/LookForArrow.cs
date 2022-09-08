using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForArrow : MonoBehaviour
{
    //[SerializeField] OVRCameraRig ovrCameraRig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.Find("Objetivo").transform);

        //Vector3 centerAnchor = ovrCameraRig.centerEyeAnchor.position;

        //transform.Translate(new Vector3(centerAnchor.x, centerAnchor.y + 0.651f, centerAnchor.z + 1));
        
    }
}
