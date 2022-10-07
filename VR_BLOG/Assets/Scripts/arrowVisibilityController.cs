using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class arrowVisibilityController : MonoBehaviour
{
    public GameObject target;
    public Camera cam;
    public GameObject arrow;
    public Toggle toggle;
    private bool IsVisible(Camera cam, GameObject target)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(cam);
        var point = target.transform.position;

        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
            {
                return false;
            }
        }
        return true;
    }

    private void Update()
    {

        if (IsVisible(cam, target))
        {
            arrow.SetActive(false);
        }
        else 
        {
            if (toggle.isOn)
            {
                arrow.SetActive(true);
            }
                    
        }
    }
}
