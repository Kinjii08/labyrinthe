using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;
    [SerializeField]
    AudioClip sndOpen, sndDenied;
    private AudioSource myAudioSource;

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    GameObject particule;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && CanOpen)
        {
            myAudioSource.PlayOneShot(sndOpen);
            myAnimator.enabled = true;
            particule.SetActive(true);
        }else
        {
            myAudioSource.PlayOneShot(sndDenied);
        }
    }
}
