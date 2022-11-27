using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator characterAnimator;

    [SerializeField] private Button _idleBtn;
    [SerializeField] private Button _talkingBtn;
    [SerializeField] private Button _walkingBtn;

    private void Start() {
         _idleBtn.onClick.AddListener (() => characterAnimator.Play("Idle"));
        _talkingBtn.onClick.AddListener(() => characterAnimator.Play("Talking"));
        _walkingBtn.onClick.AddListener(() => characterAnimator.Play("Walking"));
    }
}
