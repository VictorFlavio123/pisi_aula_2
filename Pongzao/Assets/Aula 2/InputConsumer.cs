using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputConsumer : MonoBehaviour
{
    
    
    public void MovePaddle(float direction, PlayerPaddle paddle)
    {
        paddle.SetDirection(direction);
    }


}
