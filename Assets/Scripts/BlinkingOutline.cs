using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingOutline : MonoBehaviour
{
    [SerializeField] GameObject OutlineOnCheck;
    [SerializeField] int BlinkTime = 5;

    WaitForSeconds withTime = new WaitForSeconds(0.5f);
    private bool isBlinking = false;

    /// <summary>
    /// This is used by Model target's event
    /// </summary>
    public void DoReset()
    {
        BlinkTime = 5;
        isBlinking = false;
        StopCoroutine(DoBlinkCoroutine());
    }

    public void DoBlink() {
        if (isBlinking)
            return;

        StartCoroutine(DoBlinkCoroutine());
        isBlinking = true;
    }

    private IEnumerator DoBlinkCoroutine()
    {
        yield return withTime;
        OutlineOnCheck.SetActive(false);
        yield return withTime;
        OutlineOnCheck.SetActive(true);
        BlinkTime --;
        Debug.Log("Reset");

        if (BlinkTime >= 0)
        {
            yield return DoBlinkCoroutine();            
        }
        else
        {
            OutlineOnCheck.SetActive(false);
            isBlinking = false;
        }
    }
}
