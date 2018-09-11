using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBehavior : MonoBehaviour {

    public GameObject ghost;
    public Animator animator;
    public float waitForSeconds = 3f;

    private void OnTriggerEnter(Collider other)
    {
        ActivateGhost();
        Debug.Log("activate ghost triggered");
    }

    public void ActivateGhost() {

        ghost.SetActive(true);
        animator.SetTrigger("StartGhostTrigger");

        StartCoroutine(DeactivateGhost());
    }

    public IEnumerator DeactivateGhost() {
        yield return new WaitForSecondsRealtime(waitForSeconds);
        ghost.SetActive(false);
    }
}
