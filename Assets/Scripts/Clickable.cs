using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();

    //private void FixedUpdate()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;

    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
    //        {
    //            unityEvent.Invoke();
    //        }
    //    }
    //}

    /// <summary>
    // For IOS
    /// </summary>
    private void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }

    }

    //private void FixedUpdate()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        foreach (Touch t in Input.touches)
    //        {
    //            //Debug.LogError($"current touch {Input.touches}");
    //            //Debug.LogError($"touch count is {Input.touchCount}");
    //            Vector3 touchPos = t.position;
    //            if (t.phase == TouchPhase.Began)
    //            {
    //                Ray ray = Camera.main.ScreenPointToRay(touchPos);
    //                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
    //                if (hit.collider != null && hit.transform == transform)
    //                {
    //                    unityEvent.Invoke();
    //                    // Debug.Log($"Hit: {hit.transform.name}");
    //                    //myOnMouseDown();
    //                    break;
    //                }
    //            }
    //        }
    //    }
    //}
}
