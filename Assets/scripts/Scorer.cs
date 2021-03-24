using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numberOfHits = -1;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "hit"){
             numberOfHits++;
             Debug.Log("You've bumped into a thing this many times:" + numberOfHits);
        }
    }
}
