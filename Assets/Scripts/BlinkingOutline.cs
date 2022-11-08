using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingOutline : MonoBehaviour
{
    [SerializeField] GameObject OutlineOnCheck;
    WaitForSeconds withTime = new WaitForSeconds(0.5f);
    [SerializeField] int BlinkTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoBlink());
    }

    private IEnumerator DoBlink()
    {
        yield return withTime;
        OutlineOnCheck.SetActive(false);
        yield return withTime;
        OutlineOnCheck.SetActive(true);
        BlinkTime --;
        Debug.Log("Reset");

        if (BlinkTime >= 0)
        {
            yield return DoBlink();            
        }
        else
        {
            OutlineOnCheck.SetActive(false);
        }


    }
    

    
}
