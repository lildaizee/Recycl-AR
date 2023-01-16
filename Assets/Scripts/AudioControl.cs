using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;

    private bool isCalling = false;

    public void CheckAudio()
    {
        if (isCalling) return;

        isCalling = true;
        StartCoroutine(CheckAudioRoutine());

        IEnumerator CheckAudioRoutine()
        {
            animator.SetBool("StopTalking", false);
            while (audioSource.isPlaying)
                yield return null;

            animator.SetBool("StopTalking", true);
            isCalling = false;
        }
    }

}
