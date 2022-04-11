using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bouncing : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter(Collider c){
        
        audioSource.PlayOneShot(audioClip, GetComponent<Rigidbody>().velocity.magnitude);
    }
}
