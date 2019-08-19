using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSource : MonoBehaviour
{
    public InputManager inputManager;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
            inputManager.Shoot();
        if (Input.GetKeyDown(KeyCode.R))
            inputManager.RestartGame();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        inputManager.MovePlayer(moveHorizontal, moveVertical);
    }
}
