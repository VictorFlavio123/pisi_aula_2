using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSource : MonoBehaviour
{
    public InputManager inputManager;

    // Update is called once per frame
    void Update()
    {
        inputManager.SetPlayerMovementInput(0, Input.GetAxis("Vertical1"));
        inputManager.SetPlayerMovementInput(1, Input.GetAxis("Vertical2"));
        inputManager.SetPlayerTurnInput(0, Input.GetAxis("Horizontal1"));
        inputManager.SetPlayerTurnInput(1, Input.GetAxis("Horizontal2"));
        inputManager.SetPlayerShootingPressed(0, Input.GetButtonDown("Fire1"));
        inputManager.SetPlayerShootingPressed(1, Input.GetButtonDown("Fire2"));
        inputManager.SetPlayerShootingReleased(0, Input.GetButtonUp("Fire1"));
        inputManager.SetPlayerShootingReleased(1, Input.GetButtonUp("Fire2"));
        inputManager.SetPlayerShootCharging(0, Input.GetButton("Fire1"));
        inputManager.SetPlayerShootCharging(1, Input.GetButton("Fire2"));
    }
}
