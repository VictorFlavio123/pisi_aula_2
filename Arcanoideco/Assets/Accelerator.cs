using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour {

    public float addSpeed;

    private void OnTriggerEnter(Collider other)
    {
        var b = other.GetComponent<BolinhaPhysics>();
        if (b != null)
        {
            //b.maxSpeed += b.maxSpeed.normalized * addSpeed;
            //b.minSpeed += b.minSpeed.normalized * addSpeed;
            b.myRigidbody.velocity += b.myRigidbody.velocity.normalized * addSpeed;
        }
    }
}
