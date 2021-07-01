using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField]
    Transform myTarget;

    [SerializeField]
    AtomScript atomScript;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            atomScript.target = myTarget;
        }
    }
}
