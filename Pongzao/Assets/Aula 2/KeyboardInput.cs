using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public PlayerPaddle paddle;
    public InputConsumer consumer;

    // Update is called once per frame
    void Update()
    {
        float dir = Input.GetAxis("Vertical");
        consumer.MovePaddle(dir, paddle);
    }
}
