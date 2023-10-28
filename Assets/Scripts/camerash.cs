using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerash : MonoBehaviour
{
    public SkydivingController wc;
    public float shaking = 0.005f;

    //private bool shakingStarted = false;
    //public AudioSource playSound;
    //private void Start()
    //{
    //    playSound = GetComponent<AudioSource>(); // Get the Audio Source component on this GameObject
    //}

    private void LateUpdate()
    {
        float mod_shaking = shaking * wc.percentage;

        //if (!shakingStarted && mod_shaking > 0)
        //{
        //    // Play the audio when shaking starts
        //    playSound.Play();
        //    shakingStarted = true;
        //}

        transform.localPosition = new Vector3(Random.Range(-mod_shaking, mod_shaking), Random.Range(-mod_shaking, mod_shaking), 0); 
    }
}

