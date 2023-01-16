using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;

    private void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
        //this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            animator.SetBool("StopTalking", true);
        }
    }

    //public void CallCouritine()
    //{

    //}

    //IEnumerator CheckAudio(){

    //yield return null
    //if audiosource is playing, yield return null talking
    //startcouritine check audio
    //found check couritine

    //public void GazeEntrance()
    //{
    //    if (this.audioSource.isPlaying)
    //    {
    //        this.animator.Play("Talking");
    //        this.audioSource.Stop();
    //    }
    //    else
    //    {
    //        this.animator.Play("Standing");
    //        this.audioSource.Play();
    //    }
    //}
}
