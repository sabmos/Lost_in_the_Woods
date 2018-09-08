using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopOfHillTrigger : MonoBehaviour {

    public GameObject decisionMenu;
    public AudioSource decisionMenuAudioSource;

    private float secondsToWait = 3f;
    private bool wolfGrowlPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        // Call our DogGrowl IEnumerator
        StartCoroutine(WolfGrowl());
    }

    // Plays a dog growling sound after the user enters the collider trigger
    // at the top of the hill.
    public IEnumerator WolfGrowl () {

        // Wait for a few seconds, and then play a dog growl sound
        yield return new WaitForSeconds(secondsToWait);
        GameObject wolfSoundObject = GameObject.Find("Wolf_Growl");
        AudioSource wolfSound = wolfSoundObject.GetComponent<AudioSource>();
        if (!wolfGrowlPlayed) {
            wolfSound.Play();
            Debug.Log("dog growl played");
            wolfGrowlPlayed = true;
            StartCoroutine(OpenDecisionsMenu());
        }
    }

    // Opens the decisions menu after a few seconds
    public IEnumerator OpenDecisionsMenu() {

        // Wait a few more seconds, then display a decision menu
        yield return new WaitForSecondsRealtime(secondsToWait);
        decisionMenu.SetActive(true);
        decisionMenuAudioSource.Play();
    }
}
