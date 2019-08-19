using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            var sm = Component.FindObjectOfType<StageManager>();
            sm.RespawnBall();
        }
    }
}
