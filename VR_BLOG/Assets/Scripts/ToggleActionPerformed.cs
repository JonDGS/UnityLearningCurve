using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleActionPerformed : MonoBehaviour
{
    public GameObject arrow;
    public void ToggleChanged(bool value) 
    {
        arrow.SetActive(value);   
    }

}
