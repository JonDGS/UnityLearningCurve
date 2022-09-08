using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private OVRCameraRig overCameraRig;
    [SerializeField] private Vector3 offset;
    [SerializeField] private TextMeshPro debugText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = GetCameraPos();
        Debug.Log("Camera Position: " + cameraPos);

        debugText.text = cameraPos.ToString();

        //transform.position = cameraPos + offset;
    }

    Vector3 GetCameraPos()
    {
        // Remove this line if you are refering the OVRCameraRig component 
        // through the inspector to the script.
        overCameraRig = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>();
        return overCameraRig.centerEyeAnchor.position;
    }
}
