using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARController : MonoBehaviour
{

    public GameObject ARModelTarget;
    public GameObject ScanPanel;
    public GameObject Avatar;

    public void OpenModelTarget()
    {
        if (ARModelTarget.activeInHierarchy == true)
        {
            ARModelTarget.SetActive(false);
            ScanPanel.SetActive(true);
            Avatar.SetActive(true);
        }
        else
        {
            ARModelTarget.SetActive(true);
            ScanPanel.SetActive(false);
            Avatar.SetActive(false);
            
        }
    }
    
    
    
    //public void whenButtonClicked()
    //{
    //    if (ARModelTarget.activeInHierarchy == true)
    //    {
    //        ARModelTarget.SetActive(false);
    //    }
    //    else
    //    {
    //        ARModelTarget.SetActive(true);
    //    }
    //}
    
}
