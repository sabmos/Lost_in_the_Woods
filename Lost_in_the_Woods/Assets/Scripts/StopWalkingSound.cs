using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalkingSound : MonoBehaviour {

    AudioSource[] audios;
    AudioSource walkingSource;

    void Start()
    {
        audios = GetComponents<AudioSource>();
        walkingSource = audios[1];
    }

    public void StopWalking() {
        walkingSource.Stop();
    }
}
