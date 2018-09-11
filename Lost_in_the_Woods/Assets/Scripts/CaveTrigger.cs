using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTrigger : MonoBehaviour {

    public GameObject soundSource;
    public Animator fadeToBlack;
    public Animator soundMovesCloser;
    AudioSource[] aSource;

    void Start()
    {
        aSource = soundSource.GetComponents<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // play audio source
        aSource[0].Play();
        aSource[1].Play();

        // run fade to black animation
        fadeToBlack.SetTrigger("FadeToBlackTrigger");

        // run animation that brings sound closer to the user
        soundMovesCloser.SetTrigger("MoveSoundCloser");
    }

}