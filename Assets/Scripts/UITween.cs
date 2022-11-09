using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITween : MonoBehaviour
{
    [SerializeField] GameObject ImagePopup;
    [SerializeField] GameObject ButtonPopup;
    [SerializeField] GameObject MainPagePanel;


    // Start is called before the first frame update
    public void Start()
    {
        LeanTween.moveY(ImagePopup, 800f, .9f);
        //LeanTween.scale(ImageAR, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        //LeanTween.moveLocal(ImageAR, new Vector3(0f, 3f, 2f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        //LeanTween.scale(ImageAR, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }

    void InsertButton()
    {
        LeanTween.moveX(ButtonPopup, 100f, .9f);
    }

    public void OpenPanel()
    {
        if (MainPagePanel != null)
        {
            MainPagePanel.SetActive(true);
            InsertButton();
        }
    }

}
