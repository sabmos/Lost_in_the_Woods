using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    public GameObject destination;
    public NavMeshAgent agent;

    // I am only using this for testing
    private void Start()
    {
        /* USED FOR TESTING
        Vector3 destinationVector3 = destination.transform.position;
        agent.SetDestination(destinationVector3);
        */
    }

    // Update is called once per frame
    void Update () {
        
    }

    // Move our argent
    public void MoveTo(GameObject destinationObject) {
        Vector3 destinationVector3 = destinationObject.transform.position;
        agent.SetDestination(destinationVector3);
    }
}
