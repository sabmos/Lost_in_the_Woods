using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RelayPointTrigger : MonoBehaviour {

    public GameObject nextDestinationObject;


    private void OnTriggerEnter(Collider other)
    {
        // Identify our NavMeshAgent and assign it to a local variable
        GameObject player = GameObject.Find("Player");
        NavMeshAgent agent = player.GetComponent<NavMeshAgent>();

        // Get the Vector3 position from our GameObject
        Vector3 nextDestinationVector3 = nextDestinationObject.transform.position;

        // Make agent go to the next destination
        agent.SetDestination(nextDestinationVector3);

    }
    


}
