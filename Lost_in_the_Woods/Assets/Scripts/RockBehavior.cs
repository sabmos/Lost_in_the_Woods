using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour {

    public float thrust = 100f;
    public Rigidbody rock;

    // Make rock fall off cliff and play appropriate audio
    public void RockFall () {
        rock.AddForce(transform.forward * thrust, ForceMode.Impulse);
        GetComponent<AudioSource>().Play();
    }
}
