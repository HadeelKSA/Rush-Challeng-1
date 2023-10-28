using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collectStar : MonoBehaviour
{

    public int rotateSpeed;

    public AudioSource collectSound;

    void Start()
    {
        rotateSpeed = 1; 
    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    void OnTriggerEnter2(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem2.theScore2 += 1;
        Destroy(gameObject);
    }

}
