using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercePowerup : MonoBehaviour {

    public float pierceTime = 10;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            other.GetComponent<BolinhaPhysics>().SetPierceTime(pierceTime);
            Destroy(gameObject);

        }
    }
}
