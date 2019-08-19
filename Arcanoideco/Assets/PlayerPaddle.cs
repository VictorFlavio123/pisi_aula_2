using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    public Rigidbody myRigidbody;
    public float speed = 5;


    public void SetPaddleVelocity(float xinput)
    {
        myRigidbody.velocity = transform.right * xinput * speed;
    }
}
