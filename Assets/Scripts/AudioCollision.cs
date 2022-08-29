using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour
{
    public AudioClip clip;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }

}
