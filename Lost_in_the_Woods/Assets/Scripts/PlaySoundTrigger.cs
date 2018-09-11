using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundTrigger : MonoBehaviour {

    public GameObject soundSource;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource sound = soundSource.GetComponent<AudioSource>();
        sound.Play();
    }
}
