
using UnityEngine;

public class TriggerDoorController2 : MonoBehaviour
{
    public AudioSource DoorSound;


    [SerializeField] private Animator anim;
 //   [SerializeField] private bool openTrigger = false;
//    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "door handle";


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger(doorOpen);
            //s gameObject.SetActive(false);
            DoorSound.Play();


        }
    }
}