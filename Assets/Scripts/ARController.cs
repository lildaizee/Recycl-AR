using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{

    public GameObject ARModelTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (ARModelTarget.activeInHierarchy == true)
        {
            ARModelTarget.SetActive(false);
        }
        else
        {
            ARModelTarget.SetActive(true);
        }
    }
    
}
