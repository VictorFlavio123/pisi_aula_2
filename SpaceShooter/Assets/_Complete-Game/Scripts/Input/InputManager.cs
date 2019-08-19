using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Done_GameController gameController;
    public Done_PlayerController player;

    public void RestartGame()
    {
        gameController.Restart();
    }

    public void Shoot()
    {
        if (player != null)
            player.Shoot();
    }

    public void MovePlayer(float h, float v)
    {
        if (player != null)
            player.Move(h, v);
    }
}
