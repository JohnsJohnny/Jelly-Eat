using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOfColision : MonoBehaviour
{


    public static SoundsOfColision Instance;
    public AudioClip AudioMaca;

    public void MakeAudioMaca()
    {
        MakeSound (AudioMaca);
    }
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {

        }

    }

}